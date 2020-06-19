﻿namespace Full_Calzado
{
    partial class ReporteListadoProducto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteListadoProducto));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ListadProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosProductosFC = new Full_Calzado.DatosProductosFC();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ContenedorInfoBotones = new System.Windows.Forms.Panel();
            this.IconMinimizar = new System.Windows.Forms.PictureBox();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ListadProductosTableAdapter = new Full_Calzado.DatosProductosFCTableAdapters.ListadProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ListadProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosProductosFC)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.ContenedorInfoBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // ListadProductosBindingSource
            // 
            this.ListadProductosBindingSource.DataMember = "ListadProductos";
            this.ListadProductosBindingSource.DataSource = this.DatosProductosFC;
            // 
            // DatosProductosFC
            // 
            this.DatosProductosFC.DataSetName = "DatosProductosFC";
            this.DatosProductosFC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ContenedorInfoBotones, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.462036F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.53796F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(695, 619);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ContenedorInfoBotones
            // 
            this.ContenedorInfoBotones.Controls.Add(this.IconMinimizar);
            this.ContenedorInfoBotones.Controls.Add(this.IconCerrar);
            this.ContenedorInfoBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorInfoBotones.Location = new System.Drawing.Point(0, 0);
            this.ContenedorInfoBotones.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorInfoBotones.Name = "ContenedorInfoBotones";
            this.ContenedorInfoBotones.Size = new System.Drawing.Size(695, 40);
            this.ContenedorInfoBotones.TabIndex = 5;
            this.ContenedorInfoBotones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContenedorInfoBotones_MouseDown);
            // 
            // IconMinimizar
            // 
            this.IconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMinimizar.Image")));
            this.IconMinimizar.Location = new System.Drawing.Point(610, 0);
            this.IconMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.IconMinimizar.Name = "IconMinimizar";
            this.IconMinimizar.Size = new System.Drawing.Size(33, 37);
            this.IconMinimizar.TabIndex = 4;
            this.IconMinimizar.TabStop = false;
            this.IconMinimizar.Click += new System.EventHandler(this.IconMinimizar_Click);
            // 
            // IconCerrar
            // 
            this.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("IconCerrar.Image")));
            this.IconCerrar.Location = new System.Drawing.Point(652, 0);
            this.IconCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(34, 37);
            this.IconCerrar.TabIndex = 5;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ListadProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Full_Calzado.ReporteProdutoCate.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 43);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(689, 573);
            this.reportViewer1.TabIndex = 6;
            // 
            // ListadProductosTableAdapter
            // 
            this.ListadProductosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteListadoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(695, 619);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteListadoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteListadoProducto";
            this.Load += new System.EventHandler(this.ReporteListadoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosProductosFC)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ContenedorInfoBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel ContenedorInfoBotones;
        private System.Windows.Forms.PictureBox IconMinimizar;
        private System.Windows.Forms.PictureBox IconCerrar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListadProductosBindingSource;
        private DatosProductosFC DatosProductosFC;
        private DatosProductosFCTableAdapters.ListadProductosTableAdapter ListadProductosTableAdapter;
    }
}