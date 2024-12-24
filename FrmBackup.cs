using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows;
using System.IO;



namespace Money
{
    public partial class FrmBackup : FrmBaseGeral
    {
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void copiar_banco_acces()
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (System.IO.File.Exists(saveFileDialog1.FileName))
                    {
                        System.IO.File.Delete(saveFileDialog1.FileName);
                    }
                    System.IO.File.Copy(@"C:\Money\bin\Debug\Data\bdfinance.db", saveFileDialog1.FileName);
                    System.Windows.Forms.MessageBox.Show("Backup Realizado com Sucesso !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    System.Windows.Forms.MessageBox.Show("Operação abortada", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro" + ex.Message);
            }
        }

        private void restaurar_banco_acces()
        {
           try
            {
                //código para restaurar backup
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath.ToString() + "\\bdfinance.db"))
                    {
                        System.IO.File.Delete(System.Windows.Forms.Application.StartupPath.ToString() + "\\bdfinance.db");                       
                    }

                    System.IO.File.Copy(openFileDialog1.FileName, System.Windows.Forms.Application.StartupPath.ToString() + "\\bdfinance.db");
                    System.Windows.Forms.MessageBox.Show("Backup Restaurado com Sucesso !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    System.Windows.Forms.MessageBox.Show("Operação abortada", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ocorreu um erro" + ex.Message);
            }
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {
        }
        

        private void btnCopiar_Click(object sender, EventArgs e)
        {            
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
        }

        private void btnSair_Click(object sender, EventArgs e)
        { 
        }
        private void RestauraBanco()
        {
            try
            {
                OpenFileDialog SaveFD12 = new OpenFileDialog();
                // SaveFileDialog SaveFD12 = new SaveFileDialog();
                string FileName = "";
                SaveFD12.InitialDirectory = "C:";
                SaveFD12.FileName = "";
                SaveFD12.Title = "Choose Backup file to Restore ";
                SaveFD12.DefaultExt = "mdb";
                SaveFD12.Filter = "Sqlite Filles (*.*)|*.db|All Files|*.*";
                //SaveFD1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; 
                SaveFD12.FilterIndex = 1;
                SaveFD12.RestoreDirectory = true;
                if (SaveFD12.ShowDialog() == DialogResult.OK)
                {
                    FileName = SaveFD12.FileName;
                    string src = FileName;
                    string dst = System.Windows.Forms.Application.StartupPath + @"\bancoMoney.db";
                    System.IO.File.Copy(src, dst, true);
                    System.Windows.Forms.MessageBox.Show("Backup is Restored Successfully !", "Status do Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error while restoring backup!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void Copy(string sourceFileName, string destFileName, bool overwrite)
        {
            string sourceDir = @"C:\Money\bin\Debug\Data\bdfinance.db";
            string backupDir = @"C:\Users\Wadson\Desktop\Backup Banco SqLite\bdfinance.db";
            try
            {
                string[] origem = Directory.GetFiles(sourceDir, "*.db");
                string[] destino = Directory.GetFiles(sourceDir, "*.db");


                foreach (string f in origem)   // Copy picture files.
                {// Remove path from the file name.                    
                    string fName = f.Substring(sourceDir.Length + 1); // Use the Path.Combine method to safely append the file name to the path.
                    File.Copy(System.IO.Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName), true); // Will overwrite if the destination file already exists.
                }
                foreach (string f in destino) // Copy text files.
                {
                    string fName = f.Substring(sourceDir.Length + 1);  // Remove path from the file name.

                    try
                    {
                        File.Copy(System.IO.Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));
                    }
                    catch (IOException copyError) // Catch exception if the file was already copied.
                    {
                        Console.WriteLine(copyError.Message);
                    }
                }

                foreach (string f in destino) // Delete source files that were copied.
                {
                    File.Delete(f);
                }
                foreach (string f in origem)
                {
                    File.Delete(f);
                }

            }
            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine(dirNotFound.Message);
            }
        }

        public void copiarDiretorio(string CaminhoFonte, string CaminhoDestino, bool Sobrepor = false)
	    {

		    DirectoryInfo DiretorioFonte = new DirectoryInfo(CaminhoFonte);
		    DirectoryInfo DiretorioDestino = new DirectoryInfo(CaminhoDestino);

		    if (DiretorioFonte.Exists) {
			    if (!DiretorioDestino.Parent.Exists) {
				    throw new DirectoryNotFoundException(" O diretório de destino não existe : " + DiretorioDestino.FullName);
			    }

			    if (!DiretorioDestino.Exists)
                {
				    System.Windows.Forms.MessageBox.Show("O diretorio destino não existe, vou criá-lo","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
				    DiretorioDestino.Create();
			    }

			    //copia todos os arquivos do diretório
			    FileInfo arquivos = null;

			    foreach (FileInfo banco_bd in DiretorioFonte.GetFiles()) 
                {
				    arquivos = banco_bd;
				    if (Sobrepor)
                    {
					    arquivos.CopyTo(Path.Combine(DiretorioDestino.FullName, arquivos.Name), true);
				    }
                    else 
                    {
					    if (!File.Exists(Path.Combine(DiretorioDestino.FullName, arquivos.Name)))
                        {
						    arquivos.CopyTo(Path.Combine(DiretorioDestino.FullName, arquivos.Name), false);
					    }
				    }
			    }

			    //copia todos os subdiretorios usando recursao
			    DirectoryInfo subdir = null;

			    foreach (DirectoryInfo subdir_loopVariable in DiretorioFonte.GetDirectories()) 
                {
				    subdir = subdir_loopVariable;
				    copiarDiretorio(subdir.FullName, Path.Combine(DiretorioDestino.FullName, subdir.Name), Sobrepor);
			    }
                System.Windows.Forms.MessageBox.Show("Cópia realizada com sucesso", "Informe!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		    }
            else 
            {
                System.Windows.Forms.MessageBox.Show("Diretório origem não existe " + DiretorioFonte.FullName);
		    }
	    }

        private void btn_inicia_copia_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = "bdfinanca.sdf";

                string sourcePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string backupPath = txt_destino.Text;
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(backupPath, fileName);
                System.IO.File.Copy(sourceFile, destFile, true);
                System.Windows.Forms.MessageBox.Show("Cópia realizada com sucesso", "Informe!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Escolha um local para salvar a cópia do baco de dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ver_pastas_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Money\\Data";
            //openFileDialog1.Filter = "backup *.db|*.sdf";

            this.openFileDialog1.Filter = "Sql Compact (*.sdf)|*.sdf|SQLite (*.db)|*.db";
                //| All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
        }

        public void Diretorio_Atual()
        {
            string dirAtual = Directory.GetCurrentDirectory();
            txt_origem.Text = dirAtual;
        }
        private void btn_caminho_origem_Click(object sender, EventArgs e)
        {
            //Diretorio_Atual();

            DialogResult ofd = folderBrowserDialog1.ShowDialog();
            if (ofd == DialogResult.OK)
            {
                string backupPath = folderBrowserDialog1.SelectedPath;
                txt_origem.Text = backupPath;
            }

        }

        private void btn_caminho_destino_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_destino.Text = folderBrowserDialog1.SelectedPath;
            }          
        }

        private void Frm_Backup_Load(object sender, EventArgs e)
        {
            string currentPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                txt_origem.Text = currentPath + @"";
            txt_destino.Text = currentPath + @"\Data";
            try
            {
                Diretorio_Atual();
            }
            catch
            { 
            }
        }
    }
    //**************************************************
    //class A
    //{
    //    public static void Main()
    //    {
    //        // Connect to the local, default instance of SQL Server. 
    //        Server srv = new Server();
    //        // Reference the AdventureWorks2012 database. 
    //        Database db = default(Database);
    //        db = srv.Databases["AdventureWorks2012"];

    //        // Store the current recovery model in a variable. 
    //        int recoverymod;
    //        recoverymod = (int)db.DatabaseOptions.RecoveryModel;

    //        // Define a Backup object variable. 
    //        Backup bk = new Backup();

    //        // Specify the type of backup, the description, the name, and the database to be backed up. 
    //        bk.Action = BackupActionType.Database;
    //        bk.BackupSetDescription = "Full backup of Adventureworks2012";
    //        bk.BackupSetName = "AdventureWorks2012 Backup";
    //        bk.Database = "AdventureWorks2012";

    //        // Declare a BackupDeviceItem by supplying the backup device file name in the constructor, and the type of device is a file. 
    //        BackupDeviceItem bdi = default(BackupDeviceItem);
    //        bdi = new BackupDeviceItem("Test_Full_Backup1", DeviceType.File);

    //        // Add the device to the Backup object. 
    //        bk.Devices.Add(bdi);
    //        // Set the Incremental property to False to specify that this is a full database backup. 
    //        bk.Incremental = false;

    //        // Set the expiration date. 
    //        System.DateTime backupdate = new System.DateTime();
    //        backupdate = new System.DateTime(2006, 10, 5);
    //        bk.ExpirationDate = backupdate;

    //        // Specify that the log must be truncated after the backup is complete. 
    //        bk.LogTruncation = BackupTruncateLogType.Truncate;

    //        // Run SqlBackup to perform the full database backup on the instance of SQL Server. 
    //        bk.SqlBackup(srv);

    //        // Inform the user that the backup has been completed. 
    //        System.Console.WriteLine("Full Backup complete.");

    //        // Remove the backup device from the Backup object. 
    //        bk.Devices.Remove(bdi);

    //        // Make a change to the database, in this case, add a table called test_table. 
    //        Table t = default(Table);
    //        t = new Table(db, "test_table");
    //        Column c = default(Column);
    //        c = new Column(t, "col", DataType.Int);
    //        t.Columns.Add(c);
    //        t.Create();

    //        // Create another file device for the differential backup and add the Backup object. 
    //        BackupDeviceItem bdid = default(BackupDeviceItem);
    //        bdid = new BackupDeviceItem("Test_Differential_Backup1", DeviceType.File);

    //        // Add the device to the Backup object. 
    //        bk.Devices.Add(bdid);

    //        // Set the Incremental property to True for a differential backup. 
    //        bk.Incremental = true;

    //        // Run SqlBackup to perform the incremental database backup on the instance of SQL Server. 
    //        bk.SqlBackup(srv);

    //        // Inform the user that the differential backup is complete. 
    //        System.Console.WriteLine("Differential Backup complete.");

    //        // Remove the device from the Backup object. 
    //        bk.Devices.Remove(bdid);

    //        // Delete the AdventureWorks2012 database before restoring it
    //        // db.Drop();

    //        // Define a Restore object variable.
    //        Restore rs = new Restore();

    //        // Set the NoRecovery property to true, so the transactions are not recovered. 
    //        rs.NoRecovery = true;

    //        // Add the device that contains the full database backup to the Restore object. 
    //        rs.Devices.Add(bdi);

    //        // Specify the database name. 
    //        rs.Database = "AdventureWorks2012";

    //        // Restore the full database backup with no recovery. 
    //        rs.SqlRestore(srv);

    //        // Inform the user that the Full Database Restore is complete. 
    //        Console.WriteLine("Full Database Restore complete.");

    //        // reacquire a reference to the database
    //        db = srv.Databases["AdventureWorks2012"];

    //        // Remove the device from the Restore object.
    //        rs.Devices.Remove(bdi);

    //        // Set the NoRecovery property to False. 
    //        rs.NoRecovery = false;

    //        // Add the device that contains the differential backup to the Restore object. 
    //        rs.Devices.Add(bdid);

    //        // Restore the differential database backup with recovery. 
    //        rs.SqlRestore(srv);

    //        // Inform the user that the differential database restore is complete. 
    //        System.Console.WriteLine("Differential Database Restore complete.");

    //        // Remove the device. 
    //        rs.Devices.Remove(bdid);

    //        // Set the database recovery mode back to its original value.
    //        db.RecoveryModel = (RecoveryModel)recoverymod;

    //        // Drop the table that was added. 
    //        db.Tables["test_table"].Drop();
    //        db.Alter();

    //        // Remove the backup files from the hard disk.
    //        // This location is dependent on the installation of SQL Server
    //        System.IO.File.Delete("C:\\Program Files\\Microsoft SQL Server\\MSSQL12.MSSQLSERVER\\MSSQL\\Backup\\Test_Full_Backup1");
    //        System.IO.File.Delete("C:\\Program Files\\Microsoft SQL Server\\MSSQL12.MSSQLSERVER\\MSSQL\\Backup\\Test_Differential_Backup1");
    //    }
    //}
    ///*************************************************************
     /* public static void Backup(string strDestino)
        {
            using (SqlConnection origem = new SqlConnection(@"Data Source = bancoMoney.db;Version=3", origemFile)))

            using (SqlConnection destino = new SqlConnection(String.Format("Data Source=bancoMoney.db;Version=3", destinoFile)))
            {
                origem.Open();
                destino.Open();
                origem.BackupDatabase(destino, "main", "main", -1, null, -1);
            }
        }

    */
    
}
