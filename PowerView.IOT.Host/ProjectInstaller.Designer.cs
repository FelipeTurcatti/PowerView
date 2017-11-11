namespace PowerView.IoT.Host
{
    partial class ProjectInstaller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MetricIngestionServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.MetricIngestionServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // MetricIngestionServiceProcessInstaller
            // 
            this.MetricIngestionServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalService;
            this.MetricIngestionServiceProcessInstaller.Password = null;
            this.MetricIngestionServiceProcessInstaller.Username = null;
            // 
            // MetricIngestionServiceInstaller
            // 
            this.MetricIngestionServiceInstaller.ServiceName = "MetricIngestionService";
            this.MetricIngestionServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.MetricIngestionServiceProcessInstaller,
            this.MetricIngestionServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller MetricIngestionServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller MetricIngestionServiceInstaller;
    }
}