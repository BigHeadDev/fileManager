using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;

namespace fileManager
{
	public partial class MainForm : Form
	{
		//数据定义
		public static string path="";
		public MainForm()
		{
			InitializeComponent();
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
            path = cBoxDisks.Text;
            lblPath.Text = path;
            show(path);
        }
		
		void MainFormLoad(object sender, EventArgs e)
		{
			foreach (DriveInfo di in InitialDisk()) {
				cBoxDisks.Items.Add(di.Name);
			}
            cBoxDisks.SelectedIndex = 0;
            gBoxAttri.Visible = false;

        }
        //程序加载时，读取电脑磁盘盘符
		public static DriveInfo[] InitialDisk()
		{
			DriveInfo[] disks = DriveInfo.GetDrives();
			return disks;
		}
        /// <summary>
        /// 传入一个路径，将listBox的内容刷新
        /// </summary>
        /// <param name="path">传入路径</param>
		void show(string path)
		{
			listFiles.Items.Clear();
			DirectoryInfo TheFolder=new DirectoryInfo(path);
            try
            {
                foreach (DirectoryInfo NextFolder in TheFolder.GetDirectories())
                    this.listFiles.Items.Add("【文件夹】" + NextFolder.Name);
                foreach (FileInfo NextFile in TheFolder.GetFiles())
                    this.listFiles.Items.Add(NextFile.Name);
            }
            catch(Exception ex)
            {
                MessageBox.Show("读取磁盘出错：" + ex.Message, "提示");
                cBoxDisks.SelectedIndex = 0;
                return;
            }
		}
		
        //listBox的item双击事件
		void ListFilesDoubleClick(object sender, EventArgs e)
		{
            if (listFiles.SelectedItem == null)
            {
                return;
            }
            else
            {
                if (listFiles.SelectedItem.ToString().Contains("【文件夹】"))
                {
                    string temp = listFiles.SelectedItem.ToString().Replace("【文件夹】", "");
                    lblPath.Text = lblPath.Text + temp + "\\";
                    show(lblPath.Text);
                }
                else if (listFiles.SelectedItem.ToString().Contains(".txt"))
                {
                    FormTxtReader formTxtReader = new FormTxtReader(lblPath.Text + listFiles.SelectedItem.ToString());
                    formTxtReader.Text = lblPath.Text + listFiles.SelectedItem.ToString();
                    formTxtReader.Show();
                }
                else
                {
                    return;
                }
                btnSearchFile.Text = "查找文件";
                txtFileName.Text = "";
                gBoxAttri.Visible = false;
                txtRename.Text = "";
            }
		}
		
        /// <summary>
        /// 上一层按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		void BtnLastDirClick(object sender, EventArgs e)
		{
			if (lblPath.Text!=cBoxDisks.Text) {
				string s="";
				string[] temp=lblPath.Text.Split(new char[1]{'\\'}) ;
				for (int i = 0; i < temp.Length-2; i++) {
					s +=temp[i]+"\\";
				}
				lblPath.Text=s;
                show(lblPath.Text);
                gBoxAttri.Visible = false;
                txtRename.Text = "";
            }
            else
			{
				MessageBox.Show("不能再前了！", "提示");
			}
			
		}

        /// <summary>
        /// 根据txtName查询当前目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            if (btnSearchFile.Text=="查找文件")
            {
                if(txtFileName.Text=="")
                {
                    MessageBox.Show("请输入要查找的文件/文件夹名！","提示");
                    return;
                }
                //查找之后的集合
                List<string> newList = new List<string>();
                //遍历整个listBox
                for (int i = 0; i < listFiles.Items.Count; i++)
                {
                    //判断是否包含文件名
                    if (listFiles.Items[i].ToString().Contains(txtFileName.Text))
                    {
                        newList.Add(listFiles.Items[i].ToString());
                    }
                }
                //清除搜索前
                listFiles.Items.Clear();
                //搜索结果显示到listBox
                for (int j = 0; j < newList.Count; j++)
                {
                    listFiles.Items.Add(newList[j]);
                }
                if(listFiles.Items.Count==0)
                {
                    MessageBox.Show("抱歉，没有找到相关文件/文件夹", "提示");
                    show(lblPath.Text);
                }
                else
                {
                    MessageBox.Show("查找成功", "提示");
                    btnSearchFile.Text = "取消查找";
                }
            }
            else
            {
                show(lblPath.Text);
                btnSearchFile.Text = "查找文件";
            }
            
        }
        /// <summary>
        /// 新建文件夹操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < listFiles.Items.Count; i++)
            {
                //判断是否包含文件名
                if (listFiles.Items[i].ToString()=="【文件夹】"+txtNewFolder.Text)
                {
                    k++;
                }
            }
            if (k > 0)
            {
                MessageBox.Show("抱歉，文件已经存在，请重新输入文件名", "提示");
                return;
            }
            else
            {
                if (txtNewFolder.Text == "")
                {
                    MessageBox.Show("请输入要新建的文件夹名！", "提示");
                    return;
                }
                Directory.CreateDirectory(lblPath.Text + txtNewFolder.Text);
                MessageBox.Show("创建成功", "提示");
                show(lblPath.Text);
                gBoxAttri.Visible = false;
            }
        }

        /// <summary>
        /// 删除文件操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelFile_Click(object sender, EventArgs e)
        {
            if(listFiles.SelectedItem==null)
            {
                MessageBox.Show("请先选择要删除的文件/文件夹", "提示");
                return;
            }
            DialogResult dr = MessageBox.Show("确认删除选中文件/文件夹吗？", "删除提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                //用户选择确认的操作
                int i = listFiles.SelectedItem.ToString().Length;
                string name = listFiles.SelectedItem.ToString();
                if (name.Contains("【文件夹】"))
                {
                    Directory.Delete(lblPath.Text + name.Substring(5, i - 5));
                }
                else
                {
                    File.Delete(lblPath.Text + name);
                }
                MessageBox.Show("删除成功", "提示");
                show(lblPath.Text);
                txtRename.Text = "";
                gBoxAttri.Visible = false;
            }
            else if (dr == DialogResult.Cancel)
            {
                return;
            }
            
        }

        /// <summary>
        /// 新建文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            string fullName = lblPath.Text + txtNewFile.Text + ".txt";
            try
            {
                if (txtNewFile.Text == "")
                {
                    MessageBox.Show("请输入要新建的文件名！", "提示");
                    return;
                }
                using (FileStream file = new FileStream(fullName, FileMode.CreateNew))
                {
                    show(lblPath.Text);
                }
                FormTxtReader formTxtReader = new FormTxtReader(fullName);
                formTxtReader.Text = fullName;
                formTxtReader.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("创建文件失败：" + ex.Message, "提示");
            }
        }
        string selectpath = "";
        int ifisFolder = 1;
        /// <summary>
        /// listBox单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listFiles_Click(object sender, EventArgs e)
        {
            if (listFiles.SelectedItem == null)
            {
                //选中空
                gBoxAttri.Visible = false;
            }
            else if(listFiles.SelectedItem.ToString().Contains("【文件夹】"))
            {
                gBoxAttri.Visible = true;
                //文夹属性
                gBoxAttri.Text = listFiles.SelectedItem.ToString();
                //文件夹路径
                selectpath = lblPath.Text + listFiles.SelectedItem.ToString().Substring(5, listFiles.SelectedItem.ToString().Length - 5);
                ifisFolder = 1;
                txtRename.Text = listFiles.SelectedItem.ToString().Substring(5, listFiles.SelectedItem.ToString().Length - 5); ;
            }
            else
            {
                gBoxAttri.Visible = true;
                //文件属性
                gBoxAttri.Text = listFiles.SelectedItem.ToString();
                //文件路径
                selectpath = lblPath.Text + listFiles.SelectedItem.ToString();
                ifisFolder = 0;
                txtRename.Text = gBoxAttri.Text;
            }
        }

        //只读权限
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (ifisFolder == 0)
            {
                FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule("Everyone", FileSystemRights.Read, AccessControlType.Allow);
                setAtrribute(fileSystemAccessRule, selectpath, 0);
                MessageBox.Show(gBoxAttri.Text + "  修改权限为【可读】", "提示");
            }
            else
            {
                //设定文件ACL继承
                InheritanceFlags inherits = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;
                FileSystemAccessRule fileSystemAccessRule=new FileSystemAccessRule("Everyone", FileSystemRights.Read, inherits, PropagationFlags.None, AccessControlType.Allow);
                setAtrribute(fileSystemAccessRule, selectpath, 1);
                MessageBox.Show(gBoxAttri.Text + "  修改权限为【可读】", "提示");
            }
        }
        
        /// <summary>
        /// 文件/文件夹权限修改
        /// </summary>
        /// <param name="fileSystemAccessRule">传入修改权限对象</param>
        /// <param name="path">路径</param>
        /// <param name="ifisFolder">是否为文件夹</param>
        public static void setAtrribute(FileSystemAccessRule fileSystemAccessRule,string path,int ifisFolder)
        {
            if (ifisFolder==0)
            {
                FileInfo fileInfo = new FileInfo(path);
                //获得该文件的访问权限
                System.Security.AccessControl.FileSecurity fileSecurity = fileInfo.GetAccessControl();
                //添加ereryone用户组的访问权限规则 完全控制权限
                fileSecurity.AddAccessRule(fileSystemAccessRule);
                //设置访问权限
                fileInfo.SetAccessControl(fileSecurity);
            }
            else
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                //获得该文件夹的所有访问权限
                System.Security.AccessControl.DirectorySecurity dirSecurity = dir.GetAccessControl(AccessControlSections.All);

                //添加ereryone用户组的访问权限规则 完全控制权限
                FileSystemAccessRule everyoneFileSystemAccessRule = fileSystemAccessRule;
                bool isModified = false;
                dirSecurity.ModifyAccessRule(AccessControlModification.Add, everyoneFileSystemAccessRule, out isModified);
                //设置访问权限
                dir.SetAccessControl(dirSecurity);

            }
        }

        //可写权限
        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (ifisFolder == 0)
            {
                FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule("Everyone", FileSystemRights.Write, AccessControlType.Allow);
                setAtrribute(fileSystemAccessRule, selectpath, 0);
                MessageBox.Show(gBoxAttri.Text + "  修改权限为【可写】", "提示");
            }
            else
            {
                //设定文件ACL继承
                InheritanceFlags inherits = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;
                FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule("Everyone", FileSystemRights.Write, inherits, PropagationFlags.None, AccessControlType.Allow);
                setAtrribute(fileSystemAccessRule, selectpath, 1);
                MessageBox.Show(gBoxAttri.Text + "  修改权限为【可写】", "提示");
            }
        }

        //完全控制权限
        private void btnFullCtrl_Click(object sender, EventArgs e)
        {
            if (ifisFolder == 0)
            {
                FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow);
                setAtrribute(fileSystemAccessRule, selectpath, 0);
                MessageBox.Show(gBoxAttri.Text + "  修改权限为【完全控制】", "提示");
            }
            else
            {
                //设定文件ACL继承
                InheritanceFlags inherits = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;
                FileSystemAccessRule fileSystemAccessRule = new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, inherits, PropagationFlags.None, AccessControlType.Allow);
                setAtrribute(fileSystemAccessRule, selectpath, 1);
                MessageBox.Show(gBoxAttri.Text + "  修改权限为【完全控制】", "提示");
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if(listFiles.SelectedItem==null)
            {
                MessageBox.Show("请先选定一个文件/文件夹", "警告");
                return;
            }
            if (txtRename.Text == "")
            {
                MessageBox.Show("请输入要修改的文件/文件夹名！", "提示");
                return;
            }
            if (listFiles.SelectedItem.ToString().Contains("【文件夹】"))
            {
                //文件夹修改
                DirectoryInfo directoryInfo = new DirectoryInfo(selectpath);
                RenameDir(directoryInfo, lblPath.Text + txtRename.Text);
                show(lblPath.Text);
                gBoxAttri.Visible = false;
                txtRename.Text = "";

            }
            else
            {
                //文件修改
                FileInfo fileInfo = new FileInfo(selectpath);
                RenameFile(fileInfo, lblPath.Text + txtRename.Text);
                show(lblPath.Text);
                gBoxAttri.Visible = false;
                txtRename.Text = "";
            }
        }
        //文件重命名
        public static void RenameFile(FileInfo fInfo, string newPath)
        {
            Dictionary<string, string> logDic = new Dictionary<string, string>();
            logDic.Add("newPath", newPath);
            try
            {
                fInfo.MoveTo(newPath);
                MessageBox.Show("重命名文件成功！","提示" );
            }
            catch(Exception ex)
            {
                MessageBox.Show("重命名文件失败：" + ex.Message,"提示");
            }
        }
        //文件夹重命名
        public static void RenameDir(DirectoryInfo di, string newPath)
        {
            Dictionary<string, string> logDic = new Dictionary<string, string>();
            logDic.Add("newPath", newPath);
            try
            {
                di.MoveTo(newPath);
                MessageBox.Show("重命名文件夹成功！", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show("重命名文件夹失败：" + ex.Message, "提示");
            }
        }
    }
}
