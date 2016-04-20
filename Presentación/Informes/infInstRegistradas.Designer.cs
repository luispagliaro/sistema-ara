namespace Presentación.Informes
{
    partial class infInstRegistradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infInstRegistradas));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.txtFecha = new DevExpress.XtraReports.UI.XRPageInfo();
            this.imgLogoARA = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lblTituloEncabezado = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.lblNumeracion = new DevExpress.XtraReports.UI.XRPageInfo();
            this.sistemaARADataSet1 = new Presentación.SistemaARADataSet();
            this.institucionesTableAdapter = new Presentación.SistemaARADataSetTableAdapters.InstitucionesTableAdapter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblTitulo = new DevExpress.XtraReports.UI.XRLabel();
            this.txtCantInstituciones = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.tblEncabezado = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.lblCantInstituciones = new DevExpress.XtraReports.UI.XRLabel();
            this.sistemaARADataSet2 = new Presentación.SistemaARADataSet();
            this.jugadoresTableAdapter = new Presentación.SistemaARADataSetTableAdapters.JugadoresTableAdapter();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.tblDatos = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaARADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEncabezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaARADataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 0F;
            this.Detail.KeepTogetherWithDetailReports = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtFecha,
            this.imgLogoARA,
            this.lblTituloEncabezado});
            this.TopMargin.Dpi = 254F;
            this.TopMargin.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopMargin.HeightF = 311.625F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.StylePriority.UseFont = false;
            this.TopMargin.StylePriority.UseTextAlignment = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // txtFecha
            // 
            this.txtFecha.Dpi = 254F;
            this.txtFecha.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtFecha.Format = "{0:d\' de \'MMMM\' de \'yyyy}";
            this.txtFecha.LocationFloat = new DevExpress.Utils.PointFloat(1094.583F, 205.0799F);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.txtFecha.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.txtFecha.SizeF = new System.Drawing.SizeF(497.4166F, 58.41999F);
            this.txtFecha.StylePriority.UseFont = false;
            this.txtFecha.StylePriority.UseTextAlignment = false;
            this.txtFecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // imgLogoARA
            // 
            this.imgLogoARA.Dpi = 254F;
            this.imgLogoARA.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoARA.Image")));
            this.imgLogoARA.LocationFloat = new DevExpress.Utils.PointFloat(0F, 63.5F);
            this.imgLogoARA.Name = "imgLogoARA";
            this.imgLogoARA.SizeF = new System.Drawing.SizeF(200F, 200F);
            this.imgLogoARA.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // lblTituloEncabezado
            // 
            this.lblTituloEncabezado.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top;
            this.lblTituloEncabezado.Dpi = 254F;
            this.lblTituloEncabezado.LocationFloat = new DevExpress.Utils.PointFloat(200F, 56.91335F);
            this.lblTituloEncabezado.Name = "lblTituloEncabezado";
            this.lblTituloEncabezado.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblTituloEncabezado.SizeF = new System.Drawing.SizeF(1207.583F, 148.1666F);
            this.lblTituloEncabezado.StylePriority.UseTextAlignment = false;
            this.lblTituloEncabezado.Text = "Informe Sistema ARA";
            this.lblTituloEncabezado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblNumeracion});
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 201F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblNumeracion
            // 
            this.lblNumeracion.Dpi = 254F;
            this.lblNumeracion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeracion.LocationFloat = new DevExpress.Utils.PointFloat(1338F, 68.58012F);
            this.lblNumeracion.Name = "lblNumeracion";
            this.lblNumeracion.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblNumeracion.SizeF = new System.Drawing.SizeF(254F, 58.42F);
            this.lblNumeracion.StylePriority.UseFont = false;
            this.lblNumeracion.StylePriority.UseTextAlignment = false;
            this.lblNumeracion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTitulo});
            this.ReportHeader.Dpi = 254F;
            this.ReportHeader.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.ReportHeader.HeightF = 143.0865F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.StylePriority.UseFont = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dpi = 254F;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblTitulo.SizeF = new System.Drawing.SizeF(1592F, 100.5416F);
            this.lblTitulo.StylePriority.UseFont = false;
            this.lblTitulo.StylePriority.UseTextAlignment = false;
            this.lblTitulo.Text = "Instituciones registradas";
            this.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // txtCantInstituciones
            // 
            this.txtCantInstituciones.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Instituciones.idInstitucion")});
            this.txtCantInstituciones.Dpi = 254F;
            this.txtCantInstituciones.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantInstituciones.LocationFloat = new DevExpress.Utils.PointFloat(635.0005F, 44.979F);
            this.txtCantInstituciones.Name = "txtCantInstituciones";
            this.txtCantInstituciones.SizeF = new System.Drawing.SizeF(346.6042F, 58.42F);
            this.txtCantInstituciones.StylePriority.UseFont = false;
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Count;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.txtCantInstituciones.Summary = xrSummary1;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tblEncabezado});
            this.GroupHeader1.Dpi = 254F;
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 68.79168F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            // 
            // tblEncabezado
            // 
            this.tblEncabezado.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tblEncabezado.Dpi = 254F;
            this.tblEncabezado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblEncabezado.LocationFloat = new DevExpress.Utils.PointFloat(0.0004844666F, 0F);
            this.tblEncabezado.Name = "tblEncabezado";
            this.tblEncabezado.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 254F);
            this.tblEncabezado.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.tblEncabezado.SizeF = new System.Drawing.SizeF(1591.999F, 68.79168F);
            this.tblEncabezado.StylePriority.UseBorders = false;
            this.tblEncabezado.StylePriority.UseFont = false;
            this.tblEncabezado.StylePriority.UsePadding = false;
            this.tblEncabezado.StylePriority.UseTextAlignment = false;
            this.tblEncabezado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5});
            this.xrTableRow2.Dpi = 254F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Dpi = 254F;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "CUIT";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 0.56250023069700106D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Dpi = 254F;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "Razón social";
            this.xrTableCell4.Weight = 1.7661081565504264D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Dpi = 254F;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "Cant. jugadores";
            this.xrTableCell5.Weight = 0.56418490552108036D;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblCantInstituciones,
            this.txtCantInstituciones});
            this.GroupFooter1.Dpi = 254F;
            this.GroupFooter1.HeightF = 103.399F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // lblCantInstituciones
            // 
            this.lblCantInstituciones.Dpi = 254F;
            this.lblCantInstituciones.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantInstituciones.LocationFloat = new DevExpress.Utils.PointFloat(0.0004844666F, 44.979F);
            this.lblCantInstituciones.Name = "lblCantInstituciones";
            this.lblCantInstituciones.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblCantInstituciones.SizeF = new System.Drawing.SizeF(635F, 58.42001F);
            this.lblCantInstituciones.StylePriority.UseFont = false;
            this.lblCantInstituciones.Text = "Cantidad de instituciones registradas:";
            // 
            // sistemaARADataSet2
            // 
            this.sistemaARADataSet2.DataSetName = "SistemaARADataSet";
            this.sistemaARADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jugadoresTableAdapter
            // 
            this.jugadoresTableAdapter.ClearBeforeFill = true;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.GroupFooter2});
            this.DetailReport.DataAdapter = this.jugadoresTableAdapter;
            this.DetailReport.DataMember = "Instituciones.FK_Jugadores_Instituciones";
            this.DetailReport.DataSource = this.sistemaARADataSet1;
            this.DetailReport.Dpi = 254F;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Dpi = 254F;
            this.Detail1.HeightF = 0F;
            this.Detail1.Name = "Detail1";
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tblDatos});
            this.GroupFooter2.Dpi = 254F;
            this.GroupFooter2.HeightF = 63.5F;
            this.GroupFooter2.Name = "GroupFooter2";
            // 
            // tblDatos
            // 
            this.tblDatos.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tblDatos.Dpi = 254F;
            this.tblDatos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDatos.LocationFloat = new DevExpress.Utils.PointFloat(0.000767072F, 0F);
            this.tblDatos.Name = "tblDatos";
            this.tblDatos.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 254F);
            this.tblDatos.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.tblDatos.SizeF = new System.Drawing.SizeF(1591.999F, 63.5F);
            this.tblDatos.StylePriority.UseBorders = false;
            this.tblDatos.StylePriority.UseFont = false;
            this.tblDatos.StylePriority.UsePadding = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell6});
            this.xrTableRow1.Dpi = 254F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Instituciones.cuit")});
            this.xrTableCell1.Dpi = 254F;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Scripts.OnPrintOnPage = "xrTableCell1_PrintOnPage";
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 1.2187484750424678D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Instituciones.razonSocial")});
            this.xrTableCell2.Dpi = 254F;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.Weight = 3.8265650495228232D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Instituciones.FK_Jugadores_Instituciones.idJugador")});
            this.xrTableCell6.Dpi = 254F;
            this.xrTableCell6.Name = "xrTableCell6";
            xrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Count;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell6.Summary = xrSummary2;
            this.xrTableCell6.Weight = 1.22239971542351D;
            // 
            // infInstRegistradas
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.GroupFooter1,
            this.DetailReport});
            this.DataAdapter = this.institucionesTableAdapter;
            this.DataMember = "Instituciones";
            this.DataSource = this.sistemaARADataSet1;
            this.Dpi = 254F;
            this.FilterString = "[baja] = False";
            this.Margins = new System.Drawing.Printing.Margins(254, 254, 312, 201);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.ScriptsSource = "private void xrTableCell1_PrintOnPage(object sender, DevExpress.XtraReports.UI.Pr" +
    "intOnPageEventArgs e)\r\n{\r\nif (xrTableCell1.Text == \"-        -\")\r\n{\r\nxrTableCell" +
    "1.Text = \"S/D\";\r\n}\r\n}";
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.sistemaARADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEncabezado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaARADataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo txtFecha;
        private DevExpress.XtraReports.UI.XRPictureBox imgLogoARA;
        private DevExpress.XtraReports.UI.XRLabel lblTituloEncabezado;
        private DevExpress.XtraReports.UI.XRPageInfo lblNumeracion;
        private SistemaARADataSet sistemaARADataSet1;
        private SistemaARADataSetTableAdapters.InstitucionesTableAdapter institucionesTableAdapter;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lblTitulo;
        private DevExpress.XtraReports.UI.XRLabel txtCantInstituciones;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel lblCantInstituciones;
        private DevExpress.XtraReports.UI.XRTable tblEncabezado;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private SistemaARADataSet sistemaARADataSet2;
        private SistemaARADataSetTableAdapters.JugadoresTableAdapter jugadoresTableAdapter;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter2;
        private DevExpress.XtraReports.UI.XRTable tblDatos;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
    }
}
