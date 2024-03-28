using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButton();
        }

        private void GenerateButton()
        {
            //64 tane butonu oluşturabilmek için ayrı ayrı 64 tane yazmak yerine for döngüsü kullanırsak hepsini üst üste aynı yere veriyor. Butonların ayrı ayrı ulaşılabilirliği sıkıntı
            //kullanacağımız yöntem array oluşturma
            //buton nesneleri birer class'tır
            Button[,] buttons = new Button[8, 8];

            int top = 0;
            int left = 0;
            //konum ayarlaması için tanımlandı 

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button(); //her seferinde bize yeni bir buton oluşturacağını ve bu yüzden new'lememiz gerektiğini unutmamamız gerekiyor.
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;


                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;

                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }

                    this.Controls.Add(buttons[i, j]);
                    //buraya kadar yine üst üste oluşturur o yüzden konumunu değiştirmemiz lazım
                }
                left = 0; //8 tane oluşturunca en sola (başa) geri dönsün
                top += 50; //sıra değiştirsin düşeyde
            }
        }
    }
}
