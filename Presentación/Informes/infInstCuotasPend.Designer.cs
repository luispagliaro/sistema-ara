namespace Presentación.Informes
{
    partial class infInstCuotasPend
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infInstCuotasPend));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sistemaARADataSet1 = new Presentación.SistemaARADataSet();
            this.institucionesTableAdapter = new Presentación.SistemaARADataSetTableAdapters.InstitucionesTableAdapter();
            this.imgLogoARA = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lblTituloEncabezado = new DevExpress.XtraReports.UI.XRLabel();
            this.txtFecha = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblTitulo = new DevExpress.XtraReports.UI.XRLabel();
            this.pagosTableAdapter = new Presentación.SistemaARADataSetTableAdapters.PagosTableAdapter();
            this.cuotasTableAdapter = new Presentación.SistemaARADataSetTableAdapters.CuotasTableAdapter();
            this.sistemaARADataSet2 = new Presentación.SistemaARADataSet();
            this.lblNumeracion = new DevExpress.XtraReports.UI.XRPageInfo();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaARADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaARADataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 254F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtFecha,
            this.lblTituloEncabezado,
            this.imgLogoARA});
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 264F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblNumeracion});
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 150F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sistemaARADataSet1
            // 
            this.sistemaARADataSet1.DataSetName = "SistemaARADataSet";
            this.sistemaARADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // institucionesTableAdapter
            // 
            this.institucionesTableAdapter.ClearBeforeFill = true;
            // 
            // imgLogoARA
            // 
            this.imgLogoARA.Dpi = 254F;
            this.imgLogoARA.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoARA.Image")));
            this.imgLogoARA.LocationFloat = new DevExpress.Utils.PointFloat(0F, 64.00001F);
            this.imgLogoARA.Name = "imgLogoARA";
            this.imgLogoARA.SizeF = new System.Drawing.SizeF(200F, 200F);
            this.imgLogoARA.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // lblTituloEncabezado
            // 
            this.lblTituloEncabezado.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top;
            this.lblTituloEncabezado.Dpi = 254F;
            this.lblTituloEncabezado.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloEncabezado.LocationFloat = new DevExpress.Utils.PointFloat(200F, 57.41339F);
            this.lblTituloEncabezado.Name = "lblTituloEncabezado";
            this.lblTituloEncabezado.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblTituloEncabezado.SizeF = new System.Drawing.SizeF(1406.021F, 148.1666F);
            this.lblTituloEncabezado.StylePriority.UseFont = false;
            this.lblTituloEncabezado.StylePriority.UseTextAlignment = false;
            this.lblTituloEncabezado.Text = "Informe Sistema ARA";
            this.lblTituloEncabezado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // txtFecha
            // 
            this.txtFecha.Dpi = 254F;
            this.txtFecha.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtFecha.Format = "{0:d\' de \'MMMM\' de \'yyyy}";
            this.txtFecha.LocationFloat = new DevExpress.Utils.PointFloat(1302.583F, 205.58F);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.txtFecha.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.txtFecha.SizeF = new System.Drawing.SizeF(497.4166F, 58.41999F);
            this.txtFecha.StylePriority.UseFont = false;
            this.txtFecha.StylePriority.UseTextAlignment = false;
            this.txtFecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTitulo});
            this.ReportHeader.Dpi = 254F;
            this.ReportHeader.HeightF = 200F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dpi = 254F;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 50F);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblTitulo.SizeF = new System.Drawing.SizeF(1800F, 100.5416F);
            this.lblTitulo.StylePriority.UseFont = false;
            this.lblTitulo.StylePriority.UseTextAlignment = false;
            this.lblTitulo.Text = "Instituciones con cuotas pendientes de pago";
            this.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // pagosTableAdapter
            // 
            this.pagosTableAdapter.ClearBeforeFill = true;
            // 
            // cuotasTableAdapter
            // 
            this.cuotasTableAdapter.ClearBeforeFill = true;
            // 
            // sistemaARADataSet2
            // 
            this.sistemaARADataSet2.DataSetName = "SistemaARADataSet";
            this.sistemaARADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNumeracion
            // 
            this.lblNumeracion.Dpi = 254F;
            this.lblNumeracion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeracion.LocationFloat = new DevExpress.Utils.PointFloat(1546F, 50F);
            this.lblNumeracion.Name = "lblNumeracion";
            this.lblNumeracion.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblNumeracion.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.lblNumeracion.StylePriority.UseFont = false;
            this.lblNumeracion.StylePriority.UseTextAlignment = false;
            this.lblNumeracion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // infInstCuotasPend
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.DataAdapter = this.institucionesTableAdapter;
            this.DataMember = "Instituciones";
            this.DataSource = this.sistemaARADataSet1;
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(150, 150, 264, 150);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.sistemaARADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaARADataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private SistemaARADataSet sistemaARADataSet1;
        private SistemaARADataSetTableAdapters.InstitucionesTableAdapter institucionesTableAdapter;
        private DevExpress.XtraReports.UI.XRPictureBox imgLogoARA;
        private DevExpress.XtraReports.UI.XRLabel lblTituloEncabezado;
        private DevExpress.XtraReports.UI.XRPageInfo txtFecha;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lblTitulo;
        private SistemaARADataSetTableAdapters.PagosTableAdapter pagosTableAdapter;
        private SistemaARADataSetTableAdapters.CuotasTableAdapter cuotasTableAdapter;
        private SistemaARADataSet sistemaARADataSet2;
        private DevExpress.XtraReports.UI.XRPageInfo lblNumeracion;
    }
}
