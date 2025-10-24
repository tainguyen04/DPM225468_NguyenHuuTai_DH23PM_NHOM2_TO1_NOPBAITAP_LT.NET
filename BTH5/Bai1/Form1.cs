using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool KiemTraSNT(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) 
                {
                    return false;
                }   
            }
            return true;
        }
        private List<int> TimSNT(int n)
        {
            List<int> primes = new List<int>();

            for (int i = 2; i < n; i++)
            {
                if (KiemTraSNT(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            
            
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);


            if (KiemTraSNT(n))
            {
                txtKiemTra.Text = $"{n} là số nguyên tố";
               

            }
            else
            {
                MessageBox.Show($"{n} không phải là số nguyên tố");
            }
            List<int> primeNumbers = TimSNT(n);

            // Hiển thị các số nguyên tố nhỏ hơn n vào TextBox txtTim
            txtTim.Text = string.Join(" ", primeNumbers);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
