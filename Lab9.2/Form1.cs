using System.Security.Cryptography.X509Certificates;

namespace Lab9._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Down_side_acsesor down_side = new Down_side_acsesor();
            Height_acsesor height = new Height_acsesor();
            Upper_side_acsesor upper_side = new Upper_side_acsesor();

            down_side.Niz = Convert.ToDouble(textBox1.Text);
            upper_side.Vveerh = Convert.ToDouble(textBox2.Text);         
            height.Height = Convert.ToDouble(textBox3.Text);


            if (down_side.Niz == 0)
            { label1.Text = "Нижнее основание должно быть больше нуля !"; }
            else if (upper_side.Vveerh > down_side.Niz)
            { label1.Text = "Верхнее основание должно быть меньше нижнего!"; }
            else if (upper_side.Vveerh == down_side.Niz)
            { label1.Text = "Верхнее и нижнее основание не могут быть равны!"; }
            else if (height.Height == 0)
            { label1.Text = "Высота должна быть больше нуля !"; }
            else
            {
                Trap badabum = new Trap(down_side.Niz, upper_side.Vveerh);
                Trap_drug babum = new Trap_drug(upper_side.Vveerh, down_side.Niz, height.Height);

                label1.Text = "Полусумма основания трапеции: " + (badabum.PoluSumm_trap()).ToString();
                label5.Text = "Площадь трапеции: " + (babum.Ploshad()).ToString();
            }



            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}