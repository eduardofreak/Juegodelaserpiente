namespace Juego_de_la_serpiente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarraPuntuacionSerpiente = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarraDeNivel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BotonPuntuaciones = new System.Windows.Forms.Button();
            this.BotonInstrucciones = new System.Windows.Forms.Button();
            this.BotonIniciar = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.clearBtn = new System.Windows.Forms.Button();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblIngresa = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = global::Juego_de_la_serpiente.Properties.Resources.PuntuacionSerpiente;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.BarraPuntuacionSerpiente,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.BarraDeNivel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 298);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(500, 23);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(106, 18);
            this.toolStripStatusLabel1.Text = "Puntuacion:";
            // 
            // BarraPuntuacionSerpiente
            // 
            this.BarraPuntuacionSerpiente.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarraPuntuacionSerpiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BarraPuntuacionSerpiente.Name = "BarraPuntuacionSerpiente";
            this.BarraPuntuacionSerpiente.Size = new System.Drawing.Size(15, 18);
            this.BarraPuntuacionSerpiente.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(115, 18);
            this.toolStripStatusLabel3.Text = "                                    ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(50, 18);
            this.toolStripStatusLabel2.Text = "Nivel";
            // 
            // BarraDeNivel
            // 
            this.BarraDeNivel.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarraDeNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BarraDeNivel.Name = "BarraDeNivel";
            this.BarraDeNivel.Size = new System.Drawing.Size(15, 18);
            this.BarraDeNivel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(390, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = " 3 puntos ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = " 2 puntos ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(390, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = " 5 puntos ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(390, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = " Pierdes  ";
            // 
            // BotonPuntuaciones
            // 
            this.BotonPuntuaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonPuntuaciones.Enabled = false;
            this.BotonPuntuaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonPuntuaciones.ForeColor = System.Drawing.Color.Green;
            this.BotonPuntuaciones.Location = new System.Drawing.Point(370, 258);
            this.BotonPuntuaciones.Name = "BotonPuntuaciones";
            this.BotonPuntuaciones.Size = new System.Drawing.Size(100, 23);
            this.BotonPuntuaciones.TabIndex = 8;
            this.BotonPuntuaciones.Text = "Puntuaciones";
            this.BotonPuntuaciones.UseVisualStyleBackColor = true;
            this.BotonPuntuaciones.Click += new System.EventHandler(this.BotonPuntuaciones_Click);
            // 
            // BotonInstrucciones
            // 
            this.BotonInstrucciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonInstrucciones.ForeColor = System.Drawing.Color.Green;
            this.BotonInstrucciones.Location = new System.Drawing.Point(370, 221);
            this.BotonInstrucciones.Name = "BotonInstrucciones";
            this.BotonInstrucciones.Size = new System.Drawing.Size(100, 31);
            this.BotonInstrucciones.TabIndex = 9;
            this.BotonInstrucciones.Text = "Instrucciones";
            this.BotonInstrucciones.UseVisualStyleBackColor = true;
            this.BotonInstrucciones.Click += new System.EventHandler(this.BotonInstrucciones_Click);
            // 
            // BotonIniciar
            // 
            this.BotonIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonIniciar.Enabled = false;
            this.BotonIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonIniciar.ForeColor = System.Drawing.Color.Green;
            this.BotonIniciar.Location = new System.Drawing.Point(370, 192);
            this.BotonIniciar.Name = "BotonIniciar";
            this.BotonIniciar.Size = new System.Drawing.Size(100, 23);
            this.BotonIniciar.TabIndex = 10;
            this.BotonIniciar.Text = "Iniciar";
            this.BotonIniciar.UseVisualStyleBackColor = true;
            this.BotonIniciar.Click += new System.EventHandler(this.BotonIniciar_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.Enabled = false;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Green;
            this.clearBtn.Location = new System.Drawing.Point(414, 286);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(56, 23);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Borrar";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(96, 144);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(97, 20);
            this.NombreTxt.TabIndex = 13;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Green;
            this.BtnAgregar.Location = new System.Drawing.Point(199, 141);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(52, 23);
            this.BtnAgregar.TabIndex = 14;
            this.BtnAgregar.Text = "Add";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LblIngresa
            // 
            this.LblIngresa.AutoSize = true;
            this.LblIngresa.BackColor = System.Drawing.Color.White;
            this.LblIngresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIngresa.ForeColor = System.Drawing.Color.Green;
            this.LblIngresa.Location = new System.Drawing.Point(95, 112);
            this.LblIngresa.Name = "LblIngresa";
            this.LblIngresa.Size = new System.Drawing.Size(156, 20);
            this.LblIngresa.TabIndex = 15;
            this.LblIngresa.Text = "Ingresa tu nombre";
            this.LblIngresa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.BotonIniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Juego_de_la_serpiente.Properties.Resources.FondoSerpiente;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(500, 321);
            this.Controls.Add(this.LblIngresa);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.BotonIniciar);
            this.Controls.Add(this.BotonInstrucciones);
            this.Controls.Add(this.BotonPuntuaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(506, 350);
            this.MinimumSize = new System.Drawing.Size(506, 350);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Juego de la Serpiente";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel BarraPuntuacionSerpiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BotonPuntuaciones;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel BarraDeNivel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button BotonInstrucciones;
        private System.Windows.Forms.Button BotonIniciar;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblIngresa;
    }
}

