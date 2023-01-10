using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cavalier
{
  public partial class Form2 : Form
  {
    bool rand = false;
    static int[,] echec = new int[12, 12];
    int x, y;
    MyButton[,] grille;
    int taille = 12;
    int nb_fuite, min_fuite, lmin_fuite = 0;
    int a,b, i, j, k, l, ii, jj;
    Form1 maman;
    static int[] depi = new int[] { 2, 1, -1, -2, -2, -1, 1, 2 };
    static int[] depj = new int[] { 1, 2, 2, 1, -1, -2, -2, -1 };

    private void Form2_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = this.CreateGraphics();
      Image img = Image.FromFile("images\\cavalier1.png");
      g.DrawImage(img, 100, 100, 400, 400);
    }
    public Form2(Form1 maman, int x, int y)
    {
      this.maman = maman;
      this.x = x;
      this.y = y;
      InitializeComponent();
    }
    public Form2(Form1 maman)
    {
      rand = true;
      this.maman = maman;
      Random random = new Random();
      this.x = random.Next(1, 8);
      this.y = random.Next(1, 8);
      InitializeComponent();
    }
    private void Form2_Load(object sender, EventArgs e)
    {

      this.button1.Text = "Start Simulation";
      this.label1.Text = "";
      this.label2.Text = "";
      this.grille = new MyButton[taille, taille];
      for (int j = 0; j < taille; j++)
      {
        for (int k = 0; k < taille; k++)
        {
          MyButton b = new MyButton();
          if (j % 2 == 0 && k % 2 == 1 || k % 2 == 0 && j % 2 == 1)
          {
            b.BackColor = Color.Black;
          }
          else
          {
            b.BackColor = Color.White;
          }
          b.Location = new System.Drawing.Point(0 + (j * 50), 0 + (k * 50));
          b.Size = new System.Drawing.Size(50, 50);
          b.Text = "";
          b.X = j;
          b.Y = k;
          this.Controls.Add(b);
          if (j < 2 || j > 9 || k < 2 || k > 9)
          {
            b.Enabled = false;
            b.Visible = false;
          }
          grille[j, k] = b;
        }
      }
    }
    static int fuite(int i, int j)
    {
      int n, l;

      for (l = 0, n = 8; l < 8; l++)
        if (echec[i + depi[l], j + depj[l]] != 0) n--;

      return (n == 0) ? 9 : n;
    }
    private void button1_Click(object sender, EventArgs e)
    {
      this.button1.Enabled = false;
      if (rand)
      {
        Random random = new Random();
        ii = random.Next(1, 8);
        jj = random.Next(1, 8);
      }
      else
      {
        ii = x - 1;
        jj = y - 1;

      }
      this.label1.Text = "Case de départ: " + ii + "  " + jj;
      
      for (i = 0; i < 12; i++)
      {
        for (j = 0; j < 12; j++)
        {
          echec[i, j] = ((i < 2 | i > 9 | j < 2 | j > 9) ? -1 : 0);
        }
      }

      i = ii + 1; j = jj + 1;
      a = i - 1;
      b = j - 1;
      k = 1;
      if (grille[i, j].BackColor == Color.White)
      {
        grille[i, j].ForeColor = Color.Black;
        grille[i, j].Text = k.ToString();
      }
      else
      {
        grille[i, j].ForeColor = Color.White;
        grille[i, j].Text = k.ToString();
      }
      this.label2.Text= "1"+" ["+a.ToString() + "," + b.ToString() + "]    ";
      Application.DoEvents();
      Thread.Sleep(1000);
      echec[i, j] = 1;

      for (k = 2; k <= 64; k++)
      {
        for (l = 0, min_fuite = 11; l < 8; l++)
        {
          ii = i + depi[l]; jj = j + depj[l];

          nb_fuite = ((echec[ii, jj] != 0) ? 10 : fuite(ii, jj));

          if (nb_fuite < min_fuite)
          {
            min_fuite = nb_fuite; lmin_fuite = l;
          }
        }
        if (min_fuite == 9 & k != 64)
        {
          break;
        }
        i += depi[lmin_fuite];
        j += depj[lmin_fuite];
        if (grille[i, j].BackColor==Color.White)
        {
          grille[i, j].ForeColor = Color.Black;
          grille[i, j].Text = k.ToString();
        }
        else
        {
          grille[i, j].ForeColor = Color.White;
          grille[i, j].Text = k.ToString();
        }

        a = i - 1;
        b = j - 1;
        this.label2.Text += k.ToString() + " [" + a.ToString() + "," + b.ToString() + "]    ";
        echec[i, j] = k;

        Application.DoEvents();
        Thread.Sleep(1000);
        
      }
      this.button1.Enabled = true;
    }
    private void Form2_FormClosing(object sender, FormClosingEventArgs e)
    {
    DialogResult reponse = MessageBox.Show(
    "Sure you want to quit?",
    "Quitting",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button2,
    MessageBoxOptions.RightAlign);
      if (reponse == DialogResult.No)
      {
        e.Cancel = true;
      }
    }
  }
}
