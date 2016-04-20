namespace Presentación.Informes
{
    partial class infJugRegistrados
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infJugRegistrados));
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.tblDatos = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.lblTituloEncabezado = new DevExpress.XtraReports.UI.XRLabel();
            this.imgLogoARA = new DevExpress.XtraReports.UI.XRPictureBox();
            this.txtFecha = new DevExpress.XtraReports.UI.XRPageInfo();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.lblNumeracion = new DevExpress.XtraReports.UI.XRPageInfo();
            this.sistemaARADataSet1 = new Presentación.SistemaARADataSet();
            this.institucionesTableAdapter = new Presentación.SistemaARADataSetTableAdapters.InstitucionesTableAdapter();
            this.jugadoresTableAdapter1 = new Presentación.SistemaARADataSetTableAdapters.JugadoresTableAdapter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblTitulo = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.tblEncabezado = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.lblCantInstituciones = new DevExpress.XtraReports.UI.XRLabel();
            this.txtCantInstituciones = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tblDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaARADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEncabezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tblDatos
            // 
            this.tblDatos.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tblDatos.Dpi = 254F;
            this.tblDatos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDatos.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tblDatos.Name = "tblDatos";
            this.tblDatos.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 254F);
            this.tblDatos.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.tblDatos.SizeF = new System.Drawing.SizeF(1800F, 63.5F);
            this.tblDatos.StylePriority.UseBorders = false;
            this.tblDatos.StylePriority.UseFont = false;
            this.tblDatos.StylePriority.UsePadding = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8});
            this.xrTableRow1.Dpi = 254F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Jugadores.nroDoc")});
            this.xrTableCell2.Dpi = 254F;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Scripts.OnPrintOnPage = "xrTableCell2_PrintOnPage";
            this.xrTableCell2.Weight = 1.0520827404627748D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Jugadores.apellido")});
            this.xrTableCell6.Dpi = 254F;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.Weight = 1.3369814303488061D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Jugadores.nombre")});
            this.xrTableCell7.Dpi = 254F;
            this.xrTableCell7.Name = "xrTableCell7";
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Count;
            this.xrTableCell7.Summary = xrSummary1;
            this.xrTableCell7.Weight = 1.34557418358509D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Jugadores.Jugadores_Instituciones.razonSocial")});
            this.xrTableCell8.Dpi = 254F;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Weight = 3.3519750415603564D;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTituloEncabezado,
            this.imgLogoARA,
            this.txtFecha});
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 310F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lblTituloEncabezado
            // 
            this.lblTituloEncabezado.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Top;
            this.lblTituloEncabezado.Dpi = 254F;
            this.lblTituloEncabezado.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTituloEncabezado.LocationFloat = new DevExpress.Utils.PointFloat(200F, 57.41336F);
            this.lblTituloEncabezado.Name = "lblTituloEncabezado";
            this.lblTituloEncabezado.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblTituloEncabezado.SizeF = new System.Drawing.SizeF(1406.021F, 148.1666F);
            this.lblTituloEncabezado.StylePriority.UseFont = false;
            this.lblTituloEncabezado.StylePriority.UseTextAlignment = false;
            this.lblTituloEncabezado.Text = "Informe Sistema ARA";
            this.lblTituloEncabezado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            // sistemaARADataSet1
            // 
            this.sistemaARADataSet1.DataSetName = "SistemaARADataSet";
            this.sistemaARADataSet1.EnforceConstraints = false;
            this.sistemaARADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // institucionesTableAdapter
            // 
            this.institucionesTableAdapter.ClearBeforeFill = true;
            // 
            // jugadoresTableAdapter1
            // 
            this.jugadoresTableAdapter1.ClearBeforeFill = true;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTitulo});
            this.ReportHeader.Dpi = 254F;
            this.ReportHeader.HeightF = 139.1458F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dpi = 254F;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblTitulo.SizeF = new System.Drawing.SizeF(1800F, 100.5416F);
            this.lblTitulo.StylePriority.UseFont = false;
            this.lblTitulo.StylePriority.UseTextAlignment = false;
            this.lblTitulo.Text = "Jugadores registrados";
            this.lblTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tblEncabezado});
            this.GroupHeader1.Dpi = 254F;
            this.GroupHeader1.HeightF = 68.79168F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // tblEncabezado
            // 
            this.tblEncabezado.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tblEncabezado.Dpi = 254F;
            this.tblEncabezado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblEncabezado.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tblEncabezado.Name = "tblEncabezado";
            this.tblEncabezado.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 254F);
            this.tblEncabezado.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.tblEncabezado.SizeF = new System.Drawing.SizeF(1800F, 68.79168F);
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
            this.xrTableCell5,
            this.xrTableCell1});
            this.xrTableRow2.Dpi = 254F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Dpi = 254F;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "Nº Documento";
            this.xrTableCell3.Weight = 0.4855770720949788D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Dpi = 254F;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "Apellido";
            this.xrTableCell4.Weight = 0.61706882086919312D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Dpi = 254F;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "Nombre";
            this.xrTableCell5.Weight = 0.62103504095930573D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Dpi = 254F;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "Institución";
            this.xrTableCell1.Weight = 1.5470659139951937D;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.DataAdapter = this.institucionesTableAdapter;
            this.DetailReport.DataMember = "Jugadores.Jugadores_Instituciones";
            this.DetailReport.DataSource = this.sistemaARADataSet1;
            this.DetailReport.Dpi = 254F;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tblDatos});
            this.Detail1.Dpi = 254F;
            this.Detail1.HeightF = 63.5F;
            this.Detail1.Name = "Detail1";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblCantInstituciones,
            this.txtCantInstituciones});
            this.GroupFooter1.Dpi = 254F;
            this.GroupFooter1.HeightF = 108.5849F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // lblCantInstituciones
            // 
            this.lblCantInstituciones.Dpi = 254F;
            this.lblCantInstituciones.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantInstituciones.LocationFloat = new DevExpress.Utils.PointFloat(0F, 50.1649F);
            this.lblCantInstituciones.Name = "lblCantInstituciones";
            this.lblCantInstituciones.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblCantInstituciones.SizeF = new System.Drawing.SizeF(584.7292F, 58.42002F);
            this.lblCantInstituciones.StylePriority.UseFont = false;
            this.lblCantInstituciones.Text = "Cantidad de jugadores registrados:";
            // 
            // txtCantInstituciones
            // 
            this.txtCantInstituciones.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Jugadores.idJugador")});
            this.txtCantInstituciones.Dpi = 254F;
            this.txtCantInstituciones.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantInstituciones.LocationFloat = new DevExpress.Utils.PointFloat(584.7292F, 50.1649F);
            this.txtCantInstituciones.Name = "txtCantInstituciones";
            this.txtCantInstituciones.SizeF = new System.Drawing.SizeF(346.6042F, 58.42F);
            this.txtCantInstituciones.StylePriority.UseFont = false;
            xrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Count;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.txtCantInstituciones.Summary = xrSummary2;
            // 
            // infJugRegistrados
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.DetailReport,
            this.GroupFooter1});
            this.DataAdapter = this.jugadoresTableAdapter1;
            this.DataMember = "Jugadores";
            this.DataSource = this.sistemaARADataSet1;
            this.Dpi = 254F;
            this.FilterString = "[baja] = False";
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(150, 150, 310, 150);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.ScriptsSource = "private void xrTableCell2_PrintOnPage(object sender, DevExpress.XtraReports.UI.Pr" +
    "intOnPageEventArgs e)\r\n{\r\nif (xrTableCell2.Text.Equals(\".   .\"))\r\n{\r\nxrTableCell" +
    "2.Text = \"S/D\";\r\n}\r\n}\r\n";
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.tblDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaARADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEncabezado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private SistemaARADataSet sistemaARADataSet1;
        private SistemaARADataSetTableAdapters.InstitucionesTableAdapter institucionesTableAdapter;
        private SistemaARADataSetTableAdapters.JugadoresTableAdapter jugadoresTableAdapter1;
        private DevExpress.XtraReports.UI.XRLabel lblTituloEncabezado;
        private DevExpress.XtraReports.UI.XRPictureBox imgLogoARA;
        private DevExpress.XtraReports.UI.XRPageInfo txtFecha;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lblTitulo;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable tblEncabezado;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTable tblDatos;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRPageInfo lblNumeracion;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel lblCantInstituciones;
        private DevExpress.XtraReports.UI.XRLabel txtCantInstituciones;
    }
}
