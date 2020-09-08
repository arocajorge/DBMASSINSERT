namespace DBInsertMasivo.Winform
{
    partial class FrmInsertarMasivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInsertarMasivo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsertar = new DevExpress.XtraEditors.SimpleButton();
            this.btnLeer = new DevExpress.XtraEditors.SimpleButton();
            this.txtRuta = new DevExpress.XtraEditors.ButtonEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbProceso = new DevExpress.XtraEditors.ProgressBarControl();
            this.gcDetalle = new DevExpress.XtraGrid.GridControl();
            this.gvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnValidar = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuta.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProceso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnValidar);
            this.panel1.Controls.Add(this.btnInsertar);
            this.panel1.Controls.Add(this.btnLeer);
            this.panel1.Controls.Add(this.txtRuta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnInsertar
            // 
            this.btnInsertar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertar.ImageOptions.Image")));
            this.btnInsertar.Location = new System.Drawing.Point(851, 32);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(94, 29);
            this.btnInsertar.TabIndex = 54;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLeer.ImageOptions.Image")));
            this.btnLeer.Location = new System.Drawing.Point(651, 32);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(94, 29);
            this.btnLeer.TabIndex = 53;
            this.btnLeer.Text = "Leer";
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(177, 39);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtRuta.Size = new System.Drawing.Size(450, 22);
            this.txtRuta.TabIndex = 52;
            this.txtRuta.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtRuta_ButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Archivo validador";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbProceso);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 640);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1132, 41);
            this.panel2.TabIndex = 1;
            // 
            // pbProceso
            // 
            this.pbProceso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProceso.Location = new System.Drawing.Point(12, 11);
            this.pbProceso.Name = "pbProceso";
            this.pbProceso.Size = new System.Drawing.Size(1108, 22);
            this.pbProceso.TabIndex = 0;
            // 
            // gcDetalle
            // 
            this.gcDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDetalle.Location = new System.Drawing.Point(0, 100);
            this.gcDetalle.MainView = this.gvDetalle;
            this.gcDetalle.Name = "gcDetalle";
            this.gcDetalle.Size = new System.Drawing.Size(1132, 540);
            this.gcDetalle.TabIndex = 2;
            this.gcDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetalle});
            // 
            // gvDetalle
            // 
            this.gvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gvDetalle.GridControl = this.gcDetalle;
            this.gvDetalle.Name = "gvDetalle";
            this.gvDetalle.OptionsView.ShowAutoFilterRow = true;
            this.gvDetalle.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "RUC";
            this.gridColumn1.FieldName = "Ruc";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre";
            this.gridColumn2.FieldName = "Nombre";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnValidar
            // 
            this.btnValidar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnValidar.Location = new System.Drawing.Point(751, 32);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(94, 29);
            this.btnValidar.TabIndex = 55;
            this.btnValidar.Text = "Validar";
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // FrmInsertarMasivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 681);
            this.Controls.Add(this.gcDetalle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmInsertarMasivo";
            this.Text = "FrmInsertarMasivo";
            this.Load += new System.EventHandler(this.FrmInsertarMasivo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuta.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProceso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ButtonEdit txtRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.ProgressBarControl pbProceso;
        private DevExpress.XtraEditors.SimpleButton btnLeer;
        private DevExpress.XtraGrid.GridControl gcDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.SimpleButton btnInsertar;
        private DevExpress.XtraEditors.SimpleButton btnValidar;
    }
}