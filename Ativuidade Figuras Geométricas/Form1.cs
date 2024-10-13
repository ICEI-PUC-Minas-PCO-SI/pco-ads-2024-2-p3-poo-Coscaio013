using System;
using System.Drawing; // Certifique-se de ter isso importado para usar o Bitmap
using System.Windows.Forms;

namespace Ativuidade_Figuras_Geométricas
{
    public partial class FigurasGeometricas : Form
    {
        public FigurasGeometricas()
        {
            InitializeComponent();
            InicializarComponentesAdicionais();
            this.Size = new Size(400, 500);
        }

        private void InicializarComponentesAdicionais()
        {
            Label lblForma = new Label
            {
                Text = "Selecione uma forma:",
                Top = 20,
                Left = 20,
                Width = 200,
            };
            ComboBox cbFormas = new ComboBox
            {
                Top = 20,
                Left = 220,
                Width = 150,
            };
            cbFormas.Items.AddRange(
                new string[] { "Quadrado", "Retângulo", "Triângulo", "Círculo", "Hexágono", "Pentágono", "Octágono" }
            );
            Controls.Add(lblForma);
            Controls.Add(cbFormas);

            Label lblEntrada1 = new Label
            {
                Text = "Base:",
                Top = 60,
                Left = 20,
                Width = 100,
            };
            TextBox txtEntrada1 = new TextBox
            {
                Top = 60,
                Left = 220,
                Width = 150,
            };
            txtEntrada1.KeyPress += new KeyPressEventHandler(Numero_KeyPress);
            Controls.Add(lblEntrada1);
            Controls.Add(txtEntrada1);

            Label lblEntrada2 = new Label
            {
                Text = "Altura:",
                Top = 100,
                Left = 20,
                Width = 100,
            };
            TextBox txtEntrada2 = new TextBox
            {
                Top = 100,
                Left = 220,
                Width = 150,
                Enabled = true 
            };
            txtEntrada2.KeyPress += new KeyPressEventHandler(Numero_KeyPress);
            Controls.Add(lblEntrada2);
            Controls.Add(txtEntrada2);

            Button btnCalcular = new Button
            {
                Text = "Calcular",
                Top = 160,
                Left = 140,
            };
            Controls.Add(btnCalcular);

            // Adicionando o PictureBox
            PictureBox pictureBoxForma = new PictureBox
            {
                Top = 200,
                Left = 20,
                Width = 150,
                Height = 150,
                SizeMode = PictureBoxSizeMode.StretchImage 
            };
            Controls.Add(pictureBoxForma);

            cbFormas.SelectedIndexChanged += (sender, e) =>
            {
                if (cbFormas.SelectedItem.ToString() == "Círculo" || cbFormas.SelectedItem.ToString() == "Octágono")
                {
                    txtEntrada2.Enabled = false; 
                    txtEntrada2.Text = ""; 
                }
                else
                {
                    txtEntrada2.Enabled = true; 
                }
            };

            btnCalcular.Click += (sender, e) =>
            {
                if (cbFormas.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecione uma forma.");
                    return;
                }

                string formaSelecionada = cbFormas.SelectedItem.ToString();
                double valor1 = double.TryParse(txtEntrada1.Text, out double v1) ? v1 : 0;
                double valor2 = double.TryParse(txtEntrada2.Text, out double v2) ? v2 : 0;

                Forma forma = null;

                switch (formaSelecionada)
                {
                    case "Quadrado":
                        forma = new Quadrado(valor1);
                        break;
                    case "Retângulo":
                        forma = new Retangulo(valor1, valor2);
                        break;
                    case "Triângulo":
                        forma = new Triangulo(valor1, valor2);
                        break;
                    case "Círculo":
                        forma = new Circulo(valor1);
                        break;
                    case "Hexágono":
                        forma = new Hexagono(valor1);
                        break;
                    case "Pentágono":
                        forma = new Pentagono(valor1);
                        break;
                    case "Octágono":
                        forma = new Octagono(valor1); 
                        break;
                }

                if (forma != null)
                {
                    string resultado = forma.Mostrar();
                    MessageBox.Show(resultado, "Resultados");
                    pictureBoxForma.Image = LoadImage(forma.CaminhoImagem);
                }
            };
        }

        // Método para permitir apenas números
        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere digitado não é um número e não é um caractere de controle
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede a digitação do caractere
            }
        }

        static Image LoadImage(string path)
        {
            try
            {
                return new Bitmap(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a imagem: {ex.Message}");
                return null; 
            }
        }
    }
}
