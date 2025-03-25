namespace GMSNS;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
	
	private System.Windows.Forms.Label lblMensagem;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(800, 450);
		this.Text = "GMSNS - Garotas Mágicas Saindo no Soco";  // Definir o título da janela

		// Criar e configurar a Label
		this.lblMensagem = new System.Windows.Forms.Label();
		this.lblMensagem.Text = "Garotas Mágicas Saindo no Soco!";
		this.lblMensagem.Size = new System.Drawing.Size(200, 40);  // Definir o tamanho da Label
		this.lblMensagem.Location = new System.Drawing.Point(50, 200);  // Definir a posição da Label
		this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;  // Alinhar o texto ao centro

		// Adicionar a Label ao formulário
		this.Controls.Add(this.lblMensagem);
	}


    #endregion
}
