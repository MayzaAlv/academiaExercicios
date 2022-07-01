using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioSerializacao
{
    public class SerializacaoJson
    {
        public static string path = @"C:\teste\paciente.json";

        public static void Serializacao(List<Paciente> paciente)
        {
            try
            {
                JsonSerializer serializadorJSON = new JsonSerializer();
                StreamWriter procurador = new StreamWriter(path);
                JsonWriter escritorJSON = new JsonTextWriter(procurador);
                serializadorJSON.Serialize(escritorJSON, paciente);
                procurador.Close();
                escritorJSON.Close();

                MessageBox.Show("Sucesso para serializar com JSON");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public static void DesserializarJson()
        {
            try
            {
                string json = File.ReadAllText(path);
                List<Paciente> pacientes = JsonConvert.DeserializeObject<List<Paciente>>(json);


                string resposta = "";
                foreach (Paciente paciente in pacientes)
                {
                    resposta = resposta + paciente.Nome + "\n";
                }

                MessageBox.Show(resposta, "Alerta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
