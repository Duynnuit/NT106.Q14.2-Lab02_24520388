using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai4 : Form
    {
        private const string FILE_INPUT = "input4.txt";
        private const string FILE_OUTPUT = "output4.txt";

        public Bai4()
        {
            InitializeComponent();
            lblPage.Text = "";
        }

        [Serializable]
        public class Student
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string Phone { get; set; }
            public double Course1 { get; set; }
            public double Course2 { get; set; }
            public double Course3 { get; set; }
            public double Average => (Course1 + Course2 + Course3) / 3;
        }

        private List<Student> students = new List<Student>();
        private int currentIndex = 0;
        private string filePath = "students.bin";

        // Nút "Write to a File" - GHI vào input4.txt (KHÔNG có điểm TB)
        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (students.Count == 0)
                {
                    MessageBox.Show("Chưa có sinh viên nào! Vui lòng nhấn Add để thêm sinh viên.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Ghi vào input4.txt (KHÔNG có điểm trung bình)
                using (StreamWriter writer = new StreamWriter(FILE_INPUT))
                {
                    foreach (var s in students)
                    {
                        writer.WriteLine(s.Name);
                        writer.WriteLine(s.ID);
                        writer.WriteLine(s.Phone);
                        writer.WriteLine(s.Course1);
                        writer.WriteLine(s.Course2);
                        writer.WriteLine(s.Course3);
                        // KHÔNG ghi điểm trung bình
                    }
                }

                // Lưu vào file binary
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, students);
                }

                MessageBox.Show($"Đã ghi {students.Count} sinh viên vào {FILE_INPUT} thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút "Button to read a File" - ĐỌC từ input4.txt, TÍNH điểm TB, GHI output4.txt
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(FILE_INPUT))
                {
                    MessageBox.Show($"Không tìm thấy file {FILE_INPUT}!\nVui lòng nhấn 'Write to a File' trước.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                students.Clear();
                txtOutput.Clear();

                // ĐỌC từ input4.txt
                string[] lines = File.ReadAllLines(FILE_INPUT);

                // Mỗi sinh viên có 6 dòng (KHÔNG có điểm TB)
                for (int i = 0; i < lines.Length; i += 6)
                {
                    if (i + 5 < lines.Length)
                    {
                        try
                        {
                            Student s = new Student
                            {
                                Name = lines[i].Trim(),
                                ID = lines[i + 1].Trim(),
                                Phone = lines[i + 2].Trim(),
                                Course1 = double.Parse(lines[i + 3].Trim()),
                                Course2 = double.Parse(lines[i + 4].Trim()),
                                Course3 = double.Parse(lines[i + 5].Trim())
                                // Average tự động tính từ property
                            };

                            students.Add(s);

                            // Hiển thị trong txtOutput (CÓ điểm TB)
                            txtOutput.AppendText($"Họ tên: {s.Name}\r\n");
                            txtOutput.AppendText($"MSSV: {s.ID}\r\n");
                            txtOutput.AppendText($"Điện thoại: {s.Phone}\r\n");
                            txtOutput.AppendText($"Điểm môn 1: {s.Course1}\r\n");
                            txtOutput.AppendText($"Điểm môn 2: {s.Course2}\r\n");
                            txtOutput.AppendText($"Điểm môn 3: {s.Course3}\r\n");
                            txtOutput.AppendText($"Điểm trung bình: {s.Average:F2}\r\n");
                            txtOutput.AppendText("---------------------------\r\n\r\n");
                        }
                        catch
                        {
                            MessageBox.Show($"Lỗi định dạng dữ liệu tại dòng {i + 1}", "Cảnh báo");
                        }
                    }
                }

                // GHI ra output4.txt (CÓ điểm TB)
                WriteToOutputFile();

                MessageBox.Show($"Đã đọc {students.Count} sinh viên từ {FILE_INPUT} và ghi vào {FILE_OUTPUT}!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Hiển thị sinh viên đầu tiên
                if (students.Count > 0)
                {
                    currentIndex = 0;
                    DisplayStudent(currentIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ghi ra output4.txt (CÓ điểm trung bình)
        private void WriteToOutputFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FILE_OUTPUT))
                {
                    writer.WriteLine("DANH SÁCH SINH VIÊN");
                    writer.WriteLine("==========================================");
                    writer.WriteLine();

                    for (int i = 0; i < students.Count; i++)
                    {
                        Student s = students[i];
                        writer.WriteLine($"Sinh viên {i + 1}:");
                        writer.WriteLine($"  Họ tên: {s.Name}");
                        writer.WriteLine($"  MSSV: {s.ID}");
                        writer.WriteLine($"  Điện thoại: {s.Phone}");
                        writer.WriteLine($"  Điểm môn 1: {s.Course1}");
                        writer.WriteLine($"  Điểm môn 2: {s.Course2}");
                        writer.WriteLine($"  Điểm môn 3: {s.Course3}");
                        writer.WriteLine($"  Điểm trung bình: {s.Average:F2}");
                        writer.WriteLine("------------------------------------------");
                        writer.WriteLine();
                    }

                    writer.WriteLine($"Tổng số sinh viên: {students.Count}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi output4.txt: " + ex.Message);
            }
        }

        // Nút Add - Thêm sinh viên mới vào danh sách
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ giao diện
                string name = txtName.Text.Trim();
                string id = txtID.Text.Trim();
                string phone = txtPhone.Text.Trim();

                // Kiểm tra rỗng
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(phone) ||
                    string.IsNullOrEmpty(txtCourse1.Text) || string.IsNullOrEmpty(txtCourse2.Text) || string.IsNullOrEmpty(txtCourse3.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra MSSV: phải gồm 8 chữ số
                if (!System.Text.RegularExpressions.Regex.IsMatch(id, @"^\d{8}$"))
                {
                    MessageBox.Show("Mã số sinh viên phải có đúng 8 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra số điện thoại: phải gồm 10 chữ số và bắt đầu bằng 0
                if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^0\d{9}$"))
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra và chuyển đổi điểm
                if (!double.TryParse(txtCourse1.Text, out double course1) ||
                    !double.TryParse(txtCourse2.Text, out double course2) ||
                    !double.TryParse(txtCourse3.Text, out double course3))
                {
                    MessageBox.Show("Điểm nhập phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra điểm hợp lệ (0–10)
                if (course1 < 0 || course1 > 10 || course2 < 0 || course2 > 10 || course3 < 0 || course3 > 10)
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng sinh viên mới
                Student sv = new Student
                {
                    Name = txtName.Text.Trim(),
                    ID = txtID.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Course1 = double.Parse(txtCourse1.Text),
                    Course2 = double.Parse(txtCourse2.Text),
                    Course3 = double.Parse(txtCourse3.Text)
                };

                // Thêm vào danh sách
                students.Add(sv);

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa trắng sau khi thêm
                txtName.Clear();
                txtID.Clear();
                txtPhone.Clear();
                txtCourse1.Clear();
                txtCourse2.Clear();
                txtCourse3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            if (students.Count == 0) return;
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayStudent(currentIndex);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (students.Count == 0) return;
            if (currentIndex < students.Count - 1)
            {
                currentIndex++;
                DisplayStudent(currentIndex);
            }
        }

        private void DisplayStudent(int index)
        {
            if (index < 0 || index >= students.Count) return;

            Student st = students[index];
            txtNameRead.Text = st.Name;
            txtIDRead.Text = st.ID;
            txtPhoneRead.Text = st.Phone;
            txtCourse1Read.Text = st.Course1.ToString();
            txtCourse2Read.Text = st.Course2.ToString();
            txtCourse3Read.Text = st.Course3.ToString();
            txtAVGRead.Text = st.Average.ToString("F2");

            lblPage.Text = $"{index + 1}";
        }

        private void ClearInput()
        {
            txtName.Clear();
            txtID.Clear();
            txtPhone.Clear();
            txtCourse1.Clear();
            txtCourse2.Clear();
            txtCourse3.Clear();
            txtAVG.Clear();
        }
    }
}