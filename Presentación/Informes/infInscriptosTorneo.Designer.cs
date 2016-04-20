namespace Presentación.Informes
{
    partial class infInscriptosTorneo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infInscriptosTorneo));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sistemaARADataSet1 = new Presentación.SistemaARADataSet();
            this.institucionesTableAdapter = new Presentación.SistemaARADataSetTableAdapters.InstitucionesTableAdapter();
            this.torneosTableAdapter1 = new Presentación.SistemaARADataSetTableAdapters.TorneosTableAdapter();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
            this.DetailReport2 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail3 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.jugadoresTableAdapter = new Presentación.SistemaARADataSetTableAdapters.JugadoresTableAdapter();
            this.inscripcionesTableAdapter = new Presentación.SistemaARADataSetTableAdapters.InscripcionesTableAdapter();
            this.idTorneo = new DevExpress.XtraReports.Parameters.Parameter();
            this.fechaInicio = new DevExpress.XtraReports.Parameters.Parameter();
            this.fechaFin = new DevExpress.XtraReports.Parameters.Parameter();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaARADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
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
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 254F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 254F;
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
            // torneosTableAdapter1
            // 
            this.torneosTableAdapter1.ClearBeforeFill = true;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.DetailReport1});
            this.DetailReport.DataAdapter = this.inscripcionesTableAdapter;
            this.DetailReport.DataMember = "Torneos.FK_Inscripciones_Torneos";
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
            // DetailReport1
            // 
            this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2,
            this.DetailReport2});
            this.DetailReport1.DataAdapter = this.jugadoresTableAdapter;
            this.DetailReport1.DataMember = "Torneos.FK_Inscripciones_Torneos.Inscripciones_Jugadores";
            this.DetailReport1.DataSource = this.sistemaARADataSet1;
            this.DetailReport1.Dpi = 254F;
            this.DetailReport1.FilterString = "[fechaNacimiento] Between(?fechaInicio, ?fechaFin)";
            this.DetailReport1.Level = 0;
            this.DetailReport1.Name = "DetailReport1";
            this.DetailReport1.ReportPrintOptions.PrintOnEmptyDataSource = false;
            // 
            // Detail2
            // 
            this.Detail2.Dpi = 254F;
            this.Detail2.HeightF = 0F;
            this.Detail2.Name = "Detail2";
            // 
            // DetailReport2
            // 
            this.DetailReport2.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail3});
            this.DetailReport2.DataAdapter = this.institucionesTableAdapter;
            this.DetailReport2.DataMember = "Torneos.FK_Inscripciones_Torneos.Inscripciones_Jugadores.Jugadores_Instituciones";
            this.DetailReport2.DataSource = this.sistemaARADataSet1;
            this.DetailReport2.Dpi = 254F;
            this.DetailReport2.Level = 0;
            this.DetailReport2.Name = "DetailReport2";
            // 
            // Detail3
            // 
            this.Detail3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail3.Dpi = 254F;
            this.Detail3.HeightF = 63.5F;
            this.Detail3.KeepTogether = true;
            this.Detail3.Name = "Detail3";
            // 
            // xrTable1
            // 
            this.xrTable1.Dpi = 254F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(762F, 63.5F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5});
            this.xrTableRow1.Dpi = 254F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.CanGrow = false;
            this.xrTableCell1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Torneos.FK_Inscripciones_Torneos.Inscripciones_Jugadores.apellido")});
            this.xrTableCell1.Dpi = 254F;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Weight = 1D;
            this.xrTableCell1.WordWrap = false;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Torneos.FK_Inscripciones_Torneos.Inscripciones_Jugadores.nombre")});
            this.xrTableCell2.Dpi = 254F;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Torneos.FK_Inscripciones_Torneos.Inscripciones_Jugadores.Jugadores_Instituciones." +
                    "razonSocial")});
            this.xrTableCell3.Dpi = 254F;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Weight = 0.5D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Torneos.FK_Inscripciones_Torneos.Inscripciones_Jugadores.sexo")});
            this.xrTableCell4.Dpi = 254F;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Scripts.OnPrintOnPage = "xrTableCell4_PrintOnPage";
            this.xrTableCell4.Weight = 0.25D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Torneos.FK_Inscripciones_Torneos.Inscripciones_Jugadores.fechaNacimiento", "{0:dd/MM/yyyy}")});
            this.xrTableCell5.Dpi = 254F;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Weight = 0.25D;
            // 
            // jugadoresTableAdapter
            // 
            this.jugadoresTableAdapter.ClearBeforeFill = true;
            // 
            // inscripcionesTableAdapter
            // 
            this.inscripcionesTableAdapter.ClearBeforeFill = true;
            // 
            // idTorneo
            // 
            this.idTorneo.Name = "idTorneo";
            this.idTorneo.Type = typeof(short);
            this.idTorneo.ValueInfo = "0";
            this.idTorneo.Visible = false;
            // 
            // fechaInicio
            // 
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Type = typeof(System.DateTime);
            this.fechaInicio.Visible = false;
            // 
            // fechaFin
            // 
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Type = typeof(System.DateTime);
            this.fechaFin.Visible = false;
            // 
            // formattingRule1
            // 
            this.formattingRule1.Name = "formattingRule1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(50.27083F, 58.42F);
            this.xrLabel1.Text = "|";
            // 
            // infInscriptosTorneo
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReport});
            this.DataAdapter = this.torneosTableAdapter1;
            this.DataMember = "Torneos";
            this.DataSource = this.sistemaARADataSet1;
            this.Dpi = 254F;
            this.FilterString = "[idTorneo] = ?idTorneo";
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
            this.Margins = new System.Drawing.Printing.Margins(254, 254, 254, 254);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.idTorneo,
            this.fechaInicio,
            this.fechaFin});
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.ScriptsSource = resources.GetString("$this.ScriptsSource");
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.sistemaARADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private SistemaARADataSet sistemaARADataSet1;
        private SistemaARADataSetTableAdapters.InstitucionesTableAdapter institucionesTableAdapter;
        private SistemaARADataSetTableAdapters.TorneosTableAdapter torneosTableAdapter1;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport1;
        private DevExpress.XtraReports.UI.DetailBand Detail2;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport2;
        private DevExpress.XtraReports.UI.DetailBand Detail3;
        private SistemaARADataSetTableAdapters.JugadoresTableAdapter jugadoresTableAdapter;
        private SistemaARADataSetTableAdapters.InscripcionesTableAdapter inscripcionesTableAdapter;
        public DevExpress.XtraReports.Parameters.Parameter idTorneo;
        public DevExpress.XtraReports.Parameters.Parameter fechaInicio;
        public DevExpress.XtraReports.Parameters.Parameter fechaFin;
        private DevExpress.XtraReports.UI.FormattingRule formattingRule1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
