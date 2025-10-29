using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();

            treeView1.BeforeExpand += TreeView_BeforeExpand;
            treeView1.NodeMouseDoubleClick += TreeView_NodeMouseDoubleClick;
            treeView1.AfterSelect += TreeView_AfterSelect;

            LoadDrives(); 
        }

        private void LoadDrives()
        {
            treeView1.Nodes.Clear();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    TreeNode node = new TreeNode(drive.Name)
                    {
                        Tag = drive.RootDirectory.FullName
                    };
                    node.Nodes.Add(""); // Thêm node rỗng để có thể expand
                    treeView1.Nodes.Add(node);
                }
            }
        }

        private void TreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;

            // Xóa node rỗng và load thư mục con thật
            if (node.Nodes.Count == 1 && node.Nodes[0].Tag == null)
            {
                node.Nodes.Clear();
                LoadDirectoriesAndFiles(node);
            }
        }

        private void LoadDirectoriesAndFiles(TreeNode parentNode)
        {
            string path = parentNode.Tag as string;
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);

                // Thêm các thư mục con
                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    // Bỏ qua thư mục hệ thống và ẩn
                    if ((subDir.Attributes & FileAttributes.System) == FileAttributes.System ||
                        (subDir.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                        continue;

                    TreeNode node = new TreeNode(subDir.Name)
                    {
                        Tag = subDir.FullName
                    };
                    node.Nodes.Add(""); // Thêm node rỗng để có dấu [+]
                    parentNode.Nodes.Add(node);
                }

                // Thêm tất cả các file
                foreach (FileInfo file in dir.GetFiles())
                {
                    if ((file.Attributes & FileAttributes.System) == FileAttributes.System ||
                        (file.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                        continue;

                    // Giới hạn file size để tránh load file quá lớn
                    if (file.Length > 10 * 1024 * 1024) // > 10MB
                        continue;

                    TreeNode node = new TreeNode(file.Name)
                    {
                        Tag = file.FullName
                    };
                    parentNode.Nodes.Add(node);
                }
            }
            catch (UnauthorizedAccessException)
            {
            }
            catch (Exception)
            {
            }
        }


        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = e.Node.Tag as string;

            // Nếu là thư mục và chưa expand, expand nó
            if (Directory.Exists(path))
            {
                if (!e.Node.IsExpanded)
                {
                    e.Node.Expand();
                }
            }
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag as string;
            if (path != null && File.Exists(path))
            {
                // Nếu là file, hiển thị nội dung
                DisplayFileContent(path);
            }
            else if (path != null && Directory.Exists(path))
            {
                // Nếu là thư mục, xóa nội dung
                ClearContent();
            }
        }

        private void ClearContent()
        {
            if (pictureBox1 != null)
                pictureBox1.Image = null;

            if (richTextBox1 != null)
            {
                richTextBox1.Clear();
                richTextBox1.Visible = false;
            }

            if (pictureBox1 != null)
                pictureBox1.Visible = false;
        }

        private void DisplayFileContent(string path)
        {
            try
            {
                string ext = Path.GetExtension(path).ToLower();

                // Hiển thị hình ảnh
                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" ||
                    ext == ".bmp" || ext == ".gif" || ext == ".ico")
                {
                    DisplayImage(path);
                }
                // Hiển thị file text
                else if (ext == ".txt" || ext == ".log" || ext == ".cs" ||
                         ext == ".cpp" || ext == ".java" || ext == ".py" ||
                         ext == ".js" || ext == ".html" || ext == ".css" ||
                         ext == ".xml" || ext == ".json" || ext == ".md")
                {
                    DisplayText(path);
                }
                else
                {
                    // File không hỗ trợ xem trước
                    if (richTextBox1 != null)
                    {
                        richTextBox1.Visible = true;
                        richTextBox1.BringToFront();
                        richTextBox1.Text = $"File: {Path.GetFileName(path)}\n" +
                                           $"Loại: {ext}\n" +
                                           $"Kích thước: {FormatFileSize(new FileInfo(path).Length)}\n\n" +
                                           $"Không hỗ trợ xem trước cho loại file này.\n";

                    }
                    if (pictureBox1 != null)
                        pictureBox1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị file: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisplayImage(string path)
        {
            try
            {
                // Ẩn textbox, hiện picturebox
                if (richTextBox1 != null)
                    richTextBox1.Visible = false;

                if (pictureBox1 != null)
                {
                    pictureBox1.Visible = true;
                    pictureBox1.BringToFront();

                    // Giải phóng ảnh cũ
                    if (pictureBox1.Image != null)
                    {
                        Image oldImage = pictureBox1.Image;
                        pictureBox1.Image = null;
                        oldImage.Dispose();
                    }

                    // Load ảnh mới
                    using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        pictureBox1.Image = Image.FromStream(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisplayText(string path)
        {
            try
            {
                // Ẩn picturebox, hiện textbox
                if (pictureBox1 != null)
                    pictureBox1.Visible = false;

                if (richTextBox1 != null)
                {
                    richTextBox1.Visible = true;
                    richTextBox1.BringToFront();

                    // Đọc file với encoding phù hợp
                    string content = File.ReadAllText(path, System.Text.Encoding.UTF8);
                    richTextBox1.Text = content;
                }
            }
            catch (Exception ex)
            {
                if (richTextBox1 != null)
                {
                    richTextBox1.Text = "Không thể đọc file: " + ex.Message;
                }
            }
        }

        // Format kích thước file
        private string FormatFileSize(long bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = bytes;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }
            return String.Format("{0:0.##} {1}", len, sizes[order]);
        }
    }
}
