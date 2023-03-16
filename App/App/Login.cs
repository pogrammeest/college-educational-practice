using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Xml.Linq;
using Lib1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App
{
    

    public partial class Login : ParentForm
    {
        private string text = String.Empty;
        private int countAttempt;
        public Login()
        {
            InitializeComponent();
            panel2.Visible = false;
            textBox2.PasswordChar = '•';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection MyConnection = new SqlConnection(Global.CONNECTION);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command =
            new SqlCommand("SELECT * FROM Tenant WHERE personal_account = @personal_account and pass_hash =  HASHBYTES('sha1',@pass_hash)", MyConnection);
            command.Parameters.Add("@personal_account", SqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@pass_hash", SqlDbType.VarChar).Value = textBox2.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                int id = table.Rows[0].Field<int>(0);
                int role_id = table.Rows[0].Field<int>(7);
                string name = string.Format("{0} {1} {2}", table.Rows[0].Field<string>(2), table.Rows[0].Field<string>(3), table.Rows[0].Field<string>(4));

                if (role_id == 2)
                {
                    User user = new User(id, "Admin", name);
                    AdminForm m = new AdminForm((User)user);
                    NewForm(m);
                }
                if (role_id == 1)
                {
                    User user = new User(id, "Tenant", name);
                    TenantForm m = new TenantForm((User)user);
                    NewForm(m);

                }    
            }
            else
            {
                if (countAttempt > 2)
                {
                    panel2.Visible = true;
                    generateCaptcha();
                    return;
                }
                MessageBox.Show("Проверьте логин или пароль!");
                countAttempt++;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
            else
            {
                textBox2.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            //Добавим различные цвета
            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((System.Drawing.Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Gray);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            /////Линии из углов
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            ////Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            Console.WriteLine(text);
            return result;
        }
        void generateCaptcha()
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == this.text)
            {
                panel2.Visible = false;
            }
            else
            {
                MessageBox.Show("Неверно! попробуйте еще раз");
                generateCaptcha();
            }
        }
    }
}
