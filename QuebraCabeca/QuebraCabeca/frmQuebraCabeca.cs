using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuebraCabeca
{
    public partial class frmQuebraCabeca : Form
    {
        public Boolean[] posicaoVazia = new Boolean[9];


        public frmQuebraCabeca()
        {
            InitializeComponent();

        }

        private void btnClick(Button botaoClidado)
        {
            int moverDe = verificaPosicaoAtual(botaoClidado.Top, botaoClidado.Left);
            int moverPara = verificaPosicaoVazia(botaoClidado.Top, botaoClidado.Left);
            if (moverPara > 0)
            {
                moverBotao(botaoClidado, moverDe, moverPara);
            }
            lblCliques.Text = (int.Parse(lblCliques.Text) + 1).ToString();
            verificaOrdemCorreta();
        }

        private void verificaOrdemCorreta()
        {
            /*
            posicao_1 = TOP: 50 LEFT: 0 MOVE PARA: 2 E 4
            posicao_2 = TOP: 50 LEFT: 0 MOVE PARA: 1, 3 E 5
            posicao_3 = TOP: 50 LEFT: 0 MOVE PARA: 2 E 6
            posicao_4 = TOP: 50 LEFT: 0 MOVE PARA: 1, 5 E 7
            posicao_5 = TOP: 50 LEFT: 0 MOVE PARA: 2, 4, 6 E 8
            posicao_6 = TOP: 50 LEFT: 0 MOVE PARA: 3, 5 E 9
            posicao_7 = TOP: 50 LEFT: 0 MOVE PARA: 4 E 8
            posicao_8 = TOP: 50 LEFT: 0 MOVE PARA: 5, 7 E 9
            posicao_9 = TOP: 50 LEFT: 0 MOVE PARA: 6 E 8
             */

            if (
                    (btn1.Top == 50 && btn1.Left == 0) 
                    && (btn2.Top == 50 && btn2.Left == 100)
                    && (btn3.Top == 50 && btn3.Left == 200)
                    && (btn4.Top == 150 && btn4.Left == 0)
                    && (btn5.Top == 150 && btn5.Left == 100)
                    && (btn6.Top == 150 && btn6.Left == 200)
                    && (btn7.Top == 250 && btn7.Left == 0)
                    && (btn8.Top == 250 && btn8.Left == 100)
                )
            {
                tTempo.Enabled = false;
                imgVenceu.Visible = true;
            }


        }
        private void moverBotao(Button botaoClidado, int posicaoDe, int posicaoPara)
        {
            /*
            posicao_1 = TOP: 50 LEFT: 0 MOVE PARA: 2 E 4
            posicao_2 = TOP: 50 LEFT: 0 MOVE PARA: 1, 3 E 5
            posicao_3 = TOP: 50 LEFT: 0 MOVE PARA: 2 E 6
            posicao_4 = TOP: 50 LEFT: 0 MOVE PARA: 1, 5 E 7
            posicao_5 = TOP: 50 LEFT: 0 MOVE PARA: 2, 4, 6 E 8
            posicao_6 = TOP: 50 LEFT: 0 MOVE PARA: 3, 5 E 9
            posicao_7 = TOP: 50 LEFT: 0 MOVE PARA: 4 E 8
            posicao_8 = TOP: 50 LEFT: 0 MOVE PARA: 5, 7 E 9
            posicao_9 = TOP: 50 LEFT: 0 MOVE PARA: 6 E 8
             */

            int topPara = 0;
            int leftPara = 0;

            topPara = (posicaoPara == 1 || posicaoPara == 2 || posicaoPara == 3) ? 50 : (posicaoPara == 4 || posicaoPara == 5 || posicaoPara == 6) ? 150 : 250;
            leftPara = (posicaoPara == 1 || posicaoPara == 4 || posicaoPara == 7) ? 0 : (posicaoPara == 2 || posicaoPara == 5 || posicaoPara == 8) ? 100 : 200;
            botaoClidado.Top = topPara;
            botaoClidado.Left = leftPara;
            posicaoVazia[posicaoPara - 1] = false;
            posicaoVazia[posicaoDe - 1] = true;

        }
        private int verificaPosicaoVazia(int top, int left)
        {
            /*
            posicao_1 = TOP: 50 LEFT: 0 MOVE PARA: 2 E 4
            posicao_2 = TOP: 50 LEFT: 0 MOVE PARA: 1, 3 E 5
            posicao_3 = TOP: 50 LEFT: 0 MOVE PARA: 2 E 6
            posicao_4 = TOP: 50 LEFT: 0 MOVE PARA: 1, 5 E 7
            posicao_5 = TOP: 50 LEFT: 0 MOVE PARA: 2, 4, 6 E 8
            posicao_6 = TOP: 50 LEFT: 0 MOVE PARA: 3, 5 E 9
            posicao_7 = TOP: 50 LEFT: 0 MOVE PARA: 4 E 8
            posicao_8 = TOP: 50 LEFT: 0 MOVE PARA: 5, 7 E 9
            posicao_9 = TOP: 50 LEFT: 0 MOVE PARA: 6 E 8
             */
            int posicaoRetorno = 0;

            /*se estiver na posição 1*/
            if (top == 50 && left == 0)
            {
                if (posicaoVazia[1]) { posicaoRetorno = 2; }
                if (posicaoVazia[3]) { posicaoRetorno = 4; }
            }

            /*se estiver na posição 2*/
            if (top == 50 && left == 100)
            {
                if (posicaoVazia[0]) { posicaoRetorno = 1; }
                if (posicaoVazia[2]) { posicaoRetorno = 3; }
                if (posicaoVazia[4]) { posicaoRetorno = 5; }
            }

            /*se estiver na posição 3*/
            if (top == 50 && left == 200)
            {
                if (posicaoVazia[1]) { posicaoRetorno = 2; }
                if (posicaoVazia[5]) { posicaoRetorno = 6; }
            }

            /*se estiver na posição 4*/
            if (top == 150 && left == 0)
            {
                if (posicaoVazia[0]) { posicaoRetorno = 1; }
                if (posicaoVazia[4]) { posicaoRetorno = 5; }
                if (posicaoVazia[6]) { posicaoRetorno = 7; }
            }

            /*se estiver na posição 5*/
            if (top == 150 && left == 100)
            {
                if (posicaoVazia[1]) { posicaoRetorno = 2; }
                if (posicaoVazia[3]) { posicaoRetorno = 4; }
                if (posicaoVazia[5]) { posicaoRetorno = 6; }
                if (posicaoVazia[7]) { posicaoRetorno = 8; }
            }

            /*se estiver na posição 6*/
            if (top == 150 && left == 200)
            {
                if (posicaoVazia[2]) { posicaoRetorno = 3; }
                if (posicaoVazia[4]) { posicaoRetorno = 5; }
                if (posicaoVazia[8]) { posicaoRetorno = 9; }
            }

            /*se estiver na posição 7*/
            if (top == 250 && left == 0)
            {
                if (posicaoVazia[3]) { posicaoRetorno = 4; }
                if (posicaoVazia[7]) { posicaoRetorno = 8; }
            }

            /*se estiver na posição 8*/
            if (top == 250 && left == 100)
            {
                if (posicaoVazia[4]) { posicaoRetorno = 5; }
                if (posicaoVazia[6]) { posicaoRetorno = 7; }
                if (posicaoVazia[8]) { posicaoRetorno = 9; }
            }

            /*se estiver na posição 9*/
            if (top == 250 && left == 200)
            {
                if (posicaoVazia[5]) { posicaoRetorno = 6; }
                if (posicaoVazia[7]) { posicaoRetorno = 8; }
            }

            return posicaoRetorno;
        }
        private int verificaPosicaoAtual(int top, int left)
        {
            /*
            posicao_1 = TOP: 50 LEFT: 0 MOVE PARA: 2 E 4
            posicao_2 = TOP: 50 LEFT: 0 MOVE PARA: 1, 3 E 5
            posicao_3 = TOP: 50 LEFT: 0 MOVE PARA: 2 E 6
            posicao_4 = TOP: 50 LEFT: 0 MOVE PARA: 1, 5 E 7
            posicao_5 = TOP: 50 LEFT: 0 MOVE PARA: 2, 4, 6 E 8
            posicao_6 = TOP: 50 LEFT: 0 MOVE PARA: 3, 5 E 9
            posicao_7 = TOP: 50 LEFT: 0 MOVE PARA: 4 E 8
            posicao_8 = TOP: 50 LEFT: 0 MOVE PARA: 5, 7 E 9
            posicao_9 = TOP: 50 LEFT: 0 MOVE PARA: 6 E 8
             */
            int posicaoRetorno = 0;

            /*se estiver na posição 1*/
            if (top == 50 && left == 0)
            {
                posicaoRetorno = 1;
            }

            /*se estiver na posição 2*/
            if (top == 50 && left == 100)
            {
                posicaoRetorno = 2;
            }

            /*se estiver na posição 3*/
            if (top == 50 && left == 200)
            {
                posicaoRetorno = 3;
            }

            /*se estiver na posição 4*/
            if (top == 150 && left == 0)
            {
                posicaoRetorno = 4;
            }

            /*se estiver na posição 5*/
            if (top == 150 && left == 100)
            {
                posicaoRetorno = 5;
            }

            /*se estiver na posição 6*/
            if (top == 150 && left == 200)
            {
                posicaoRetorno = 6;
            }

            /*se estiver na posição 7*/
            if (top == 250 && left == 0)
            {
                posicaoRetorno = 7;
            }

            /*se estiver na posição 8*/
            if (top == 250 && left == 100)
            {
                posicaoRetorno = 8;
            }

            /*se estiver na posição 9*/
            if (top == 250 && left == 200)
            {
                posicaoRetorno = 9;
            }

            return posicaoRetorno;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            voltaPosisoesInicial();
        }
        private void voltaPosisoesInicial() {
            for (int i = 0; i < posicaoVazia.Count(); i++)
            {
                posicaoVazia[i] = false;
                if (i == 8)
                {
                    posicaoVazia[i] = true;
                }
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            btnClick(btn1);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            btnClick(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btnClick(btn3);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            btnClick(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btnClick(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btnClick(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btnClick(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btnClick(btn8);
        }

        private void btnEscolheImagem_Click(object sender, EventArgs e)
        {
            ofAbrirArquivo.Multiselect = false;
            //filtra para exibir somente arquivos de imagens
            ofAbrirArquivo.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG;";
            ofAbrirArquivo.CheckFileExists = true;
            ofAbrirArquivo.CheckPathExists = true;
            ofAbrirArquivo.FilterIndex = 2;
            ofAbrirArquivo.RestoreDirectory = true;
            ofAbrirArquivo.ReadOnlyChecked = true;
            ofAbrirArquivo.ShowReadOnly = true;

            DialogResult dr = this.ofAbrirArquivo.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String arquivo in ofAbrirArquivo.FileNames)
                {
                    Image Imagem = Image.FromFile(arquivo).GetThumbnailImage(300, 300, null, IntPtr.Zero);
                    btn1.Image = Imagem;
                    btn2.Image = Imagem;
                    btn3.Image = Imagem;
                    btn4.Image = Imagem;
                    btn5.Image = Imagem;
                    btn6.Image = Imagem;
                    btn7.Image = Imagem;
                    btn8.Image = Imagem;
                }
            }


        }
        DateTime horaInicio;
        private void btnEmbaralhar_Click(object sender, EventArgs e)
        {
            embaralhaBotoes();
            voltaPosisoesInicial();
            lblCliques.Text = "0";
            lblTempo.Text = "00:00:00";
            horaInicio = DateTime.Now;
            tTempo.Enabled = true;
            imgVenceu.Visible = false;

        }

        private void tTempo_Tick(object sender, EventArgs e)
        {
            lblTempo.Text = (DateTime.Now - horaInicio).Hours.ToString().PadLeft(2, char.Parse("0")) + ":" + (DateTime.Now - horaInicio).Minutes.ToString().PadLeft(2, char.Parse("0")) + ":" + (DateTime.Now - horaInicio).Seconds.ToString().PadLeft(2, char.Parse("0"));
        }

        private void embaralhaBotoes()
        {
            int[,] posicoesNovas = new int[8,2];
            posicoesNovas[0, 0] = 50;
            posicoesNovas[0, 1] = 0;
            posicoesNovas[1, 0] = 50;
            posicoesNovas[1, 1] = 100;
            posicoesNovas[2, 0] = 50;
            posicoesNovas[2, 1] = 200;
            posicoesNovas[3, 0] = 150;
            posicoesNovas[3, 1] = 0;
            posicoesNovas[4, 0] = 150;
            posicoesNovas[4, 1] = 100;
            posicoesNovas[5, 0] = 150;
            posicoesNovas[5, 1] = 200;
            posicoesNovas[6, 0] = 250;
            posicoesNovas[6, 1] = 0;
            posicoesNovas[7, 0] = 250;
            posicoesNovas[7, 1] = 100;


            Random randNum = new Random();
            int[] numeros = new int[8];
            numeros[0] = 9;
            numeros[1] = 9;
            numeros[2] = 9;
            numeros[3] = 9;
            numeros[4] = 9;
            numeros[5] = 9;
            numeros[6] = 9;
            numeros[7] = 9;


            for (int i = 0; i < 8; i++)
            {
                int rnd = 0;

                do
                {
                    rnd = randNum.Next(0,8);
                } while (numeros.Contains(rnd));
                numeros[i] = rnd;
            }

            btn1.Top = posicoesNovas[numeros[0], 0];
            btn1.Left = posicoesNovas[numeros[0], 1];

            btn2.Top = posicoesNovas[numeros[1], 0];
            btn2.Left = posicoesNovas[numeros[1], 1];

            btn3.Top = posicoesNovas[numeros[2], 0];
            btn3.Left = posicoesNovas[numeros[2], 1];

            btn4.Top = posicoesNovas[numeros[3], 0];
            btn4.Left = posicoesNovas[numeros[3], 1];

            btn5.Top = posicoesNovas[numeros[4], 0];
            btn5.Left = posicoesNovas[numeros[4], 1];

            btn6.Top = posicoesNovas[numeros[5], 0];
            btn6.Left = posicoesNovas[numeros[5], 1];

            btn7.Top = posicoesNovas[numeros[6], 0];
            btn7.Left = posicoesNovas[numeros[6], 1];

            btn8.Top = posicoesNovas[numeros[7], 0];
            btn8.Left = posicoesNovas[numeros[7], 1];

        }

    }
}


