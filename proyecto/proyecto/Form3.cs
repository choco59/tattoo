using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calendar.NET;
using WindowsFormsControlLibrary1;
namespace proyecto
{
    public partial class Form3 : Form
    {
        int pw;
        bool hide;
        int pwx;
       
   
        public Form3()
        {
            
            InitializeComponent();
            
            pw = panel1.Width;
            pwx = panel1.Width - 250;
            hide = false;
            explorador.Dock = DockStyle.Fill;
            explorador.Visible = true;
            WindowState = FormWindowState.Maximized;
            timer2.Enabled = true;
            calendar1.CalendarDate = DateTime.Now;
            calendar1.CalendarView = CalendarViews.Month;
          
            timer1.Start();
            pictureBox1.Visible = false;
            
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;

            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            explorador.Visible = true;
            inventario.Visible = false;
            horarios.Visible = false;
            contactos.Visible = false;
            citas.Visible = false;
            explorador.Dock = DockStyle.Fill;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           
            inventario.Visible = true;
            explorador.Visible = false;
            inventario.Dock = DockStyle.Fill;
            horarios.Visible = false;
            contactos.Visible = false;
            citas.Visible = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            explorador.Visible = false;
            inventario.Visible = false;
            horarios.Visible = false;
            contactos.Visible = false;

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            horarios.Visible = true;
            explorador.Visible = false;
            inventario.Visible = false;
            horarios.Dock = DockStyle.Fill;
            contactos.Visible = false;
            citas.Visible = false;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            contactos.Visible = true;
            explorador.Visible = false;
            inventario.Visible = false;
            horarios.Visible = false;
            contactos.Dock = DockStyle.Fill;
            citas.Visible = false;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Visible = false;
            //label4.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hide)
            {
                panel1.Width = panel1.Width + 125;

                if (panel1.Width == pw)
                {
                   
                   // bunifuImageButton1.Location = new Point(251,15);
                    pictureBox1.Visible = true;
                    timer1.Stop();
                    hide = false;
                    this.Refresh();
                   // label4.Visible = true;
                }
            }
            else
            {
                panel1.Width = panel1.Width - 125;
                

                if (panel1.Width == pwx)
                {

                    timer1.Stop();
                    hide = true;
                    this.Refresh();
                }
            }
        }

        private void menusup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuinf_Paint(object sender, PaintEventArgs e)
        {

        }

        private void explorador_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            webBrowser2.Refresh();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate(textBox1.Text);
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            webBrowser2.GoHome();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if

            ( MessageBox.Show("Seguro que desea cerrar la sesión?", "CERRAR SESIÓN", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
             Form1 f1 = new Form1();
             f1.Show();
             this.Hide();
             
            }
             
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            if
            (MessageBox.Show("Seguro que desea eliminar", "ELIMINAR PRODUCTO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
            
            
            }
        
            
            }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("dato a guardar");
        }

        private void calendar1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            
            agregar_cita f5 = new agregar_cita();
            f5.Show();
            
        }

        private void calendar2_Load(object sender, EventArgs e)
        {
            
        }
        
        private void calendar1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void calendar1_Load_2(object sender, EventArgs e)
        {
            
           
            
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            contactos.Visible = true;
            explorador.Visible = false;
            inventario.Visible = false;
            horarios.Visible = false;
            citas.Dock = DockStyle.Fill;
            citas.Visible = true;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ctatuajes.Dock = DockStyle.Fill;
           
            ctatuajes.Visible = true;
            cpiercing.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contactos.Visible = false;
            explorador.Visible = false;
            inventario.Visible = false;
            horarios.Visible = false;
            ctatuajes.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if

           (MessageBox.Show("Seguro que desea cancelar?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                contactos.Visible = false;
                explorador.Visible = false;
                inventario.Visible = false;
                horarios.Visible = false;
                ctatuajes.Visible = false;

            }
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            int a = Convert.ToInt32(anocita.Text);
            int b = Convert.ToInt32(mescita.Text);
            int c = Convert.ToInt32(diacita.Text);
            int d = Convert.ToInt32(horacita);
            int f = Convert.ToInt32(minutoscita);
           
            
            cpiercing.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ctatuajes.Visible = false;
            cpiercing.Visible = true;
            cpiercing.Dock = DockStyle.Fill;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if

         (MessageBox.Show("Seguro que desea cancelar?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cpiercing.Visible = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            calendar1.CalendarView = CalendarViews.Day;
            button10.Visible = false;
            button11.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            calendar1.CalendarView = CalendarViews.Month;
            button11.Visible = false;
            button10.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            agreg_inventario.Visible = false;
            inventario.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            inventario.Visible = false;
            agreg_inventario.Visible = true;
            agreg_inventario.Dock = DockStyle.Fill;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if

        (MessageBox.Show("Seguro que desea cancelar?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                agreg_inventario.Visible = false;
                inventario.Visible = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void calendar1_Load_3(object sender, EventArgs e)
        {
            var ce2 = new CustomEvent
            {
                IgnoreTimeComponent = false,
                EventText = "Tatuaje",
                Date = new DateTime(2017, 11, 14, 18, 0, 0),
                EventLengthInHours = 2f,
                RecurringFrequency = RecurringFrequencies.None,
                EventFont = new Font("Verdana", 12, FontStyle.Regular),
                Enabled = true,
                EventColor = Color.FromArgb(120, 255, 120),
                EventTextColor = Color.Black,
                ThisDayForwardOnly = false
            };
            calendar1.AddEvent(ce2);


            var ce3 = new CustomEvent
            {
                IgnoreTimeComponent = false,
                EventText = "Piercing",
                Date = new DateTime(2017, 11, 15, 19, 0, 0),
                EventLengthInHours = 2f,
                RecurringFrequency = RecurringFrequencies.None,
                EventFont = new Font("Verdana", 12, FontStyle.Regular),
                Enabled = false,
                EventColor = Color.FromArgb(120, 255, 120),
                EventTextColor = Color.Black,
                ThisDayForwardOnly = false
            };
            calendar1.AddEvent(ce3); 
            

        }
       
    }
}
