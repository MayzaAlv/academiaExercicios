using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioSerializacao
{
    public class SerializacaoJson
    {
        static string path = "C:\\Users\\mayza\\source\\repos\\academiaExercicios\\winForms\\exercicioSerializacao\\arquivos\\serializacao.json";

        public static void Serializacao(List<Paciente> paciente)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(paciente);
                StreamWriter escritor = new StreamWriter(path, true);
                escritor.WriteLine(jsonString);
                escritor.Flush();
                escritor.Close();

                MessageBox.Show("Sucesso para serializar com JSON");
                Application.Exit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public static void DesserializarJson()
        {
            string json = File.ReadAllText(path);

            Paciente p = JsonSerializer.Deserialize<Paciente>(json);


            //foreach (Paciente item in p)
            //{
            //    MessageBox.Show("Nome: " + item.Nome + " Idade: " + item.DataNascimento + " Cpf: " + item.Cpf);
            //}
        }
    }
}
