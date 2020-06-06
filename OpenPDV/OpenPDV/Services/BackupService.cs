using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OpenPDV.Services
{
    public class BackupService
    {
        public static void CriarBackup()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Backup Files|*.bak";
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    var conexao = System.Configuration.ConfigurationManager.ConnectionStrings["OpenPDVDBConnectionString"].ConnectionString;
                    SqlConnection.ClearAllPools();
                    SqlConnection cn = new SqlConnection(conexao);
                    SqlCommand cm = new SqlCommand();
                    cm.Connection = cn;
                    cm.CommandText = "BACKUP DATABASE [OpenPDV] TO DISK = '" + saveFileDialog.FileName + "'";
                    try
                    {
                        cn.Open();
                        cm.ExecuteNonQuery();
                    }
                    catch (Exception erro)
                    {
                        throw new Exception(erro.Message);
                    }
                    finally
                    {
                        cn.Close();
                    }
                    MessageBox.Show("Backup realizado com sucesso!", "Open PDV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
