using MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace DAL
{
    public class referencia
    {
        private conex conectar;
        
        public referencia (conex cx)
        {
            this.conectar = cx;
        }

        public void Incluir(MODELAnimal modelo)
        {
            try
            {
                
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "Insert into consulta(id,proprietario,animal,telefone,dataConsulta,anaminese,medicacao)" +
                   "Values (NULL,@prop,@animal,@tel,@data,@anaminese,@medicacao);";


                comando.Parameters.AddWithValue("@prop", modelo.Proprietario);
                comando.Parameters.AddWithValue("@animal", modelo.Animal);
                comando.Parameters.AddWithValue("@tel", modelo.Telefone);
                comando.Parameters.AddWithValue("@data", modelo.DataConsulta);
                comando.Parameters.AddWithValue("@anaminese", modelo.Anaminese);
                comando.Parameters.AddWithValue("@medicacao", modelo.Medicacao);
                comando.Connection = this.conectar.Conect;
                conectar.Conectar();

                int id = Convert.ToInt32(comando.ExecuteScalar());
                modelo.Id = id;

                
            }
            catch(MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conectar.Desconectar();
            }
        }

        public void Atualizar(MODELAnimal modelo)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conectar.Conect;
                comando.CommandText = "Update consulta set proprietario = @prop,"  +                                    
                                      "animal = @animal," +
                                      "telefone = @tel," +
                                      "dataConsulta = @data," +
                                      "anaminese = @anaminese," +
                                      "medicacao = @medicacao" +
                                      " where " +
                                      "id  = @id";
                string data = modelo.DataConsulta.ToString("yyyy / MM / dd HH:mm:ss");
                comando.Parameters.AddWithValue("@prop", modelo.Proprietario);
                comando.Parameters.AddWithValue("@animal", modelo.Animal);
                comando.Parameters.AddWithValue("@tel", modelo.Telefone);
                comando.Parameters.AddWithValue("@data", modelo.DataConsulta);
                comando.Parameters.AddWithValue("@anaminese", modelo.Anaminese);
                comando.Parameters.AddWithValue("@medicacao", modelo.Medicacao);
                comando.Parameters.AddWithValue("@id", modelo.Id);
                conectar.Conectar();
                comando.ExecuteNonQuery();
            }
            catch(MySqlException e)
            {
                throw e;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                conectar.Desconectar();
            }
            
        }

        public void Excluir(int codigo)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conectar.Conect;

                comando.CommandText = "Delete from consulta where id = @idp";
                comando.Parameters.AddWithValue("@idp", codigo);
                conectar.Conectar();
                comando.ExecuteNonQuery();
                
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                conectar.Desconectar();
            }
        }

        public DataTable Procurar(string t,string op)
        {
            try
            {
                string s;
                DataTable tabela = new DataTable();


                if (op == "Data")
                {

                    string g = t.Replace("/", "-");
                    s = "Select *from consulta where dataConsulta like '%" + g + "%'";
                    MySqlDataAdapter a = new MySqlDataAdapter(s, conectar.Conect);
                    a.Fill(tabela);


                    return tabela;
                }
                if (op == "Contato")
                {
                    s = "Select *from consulta where telefone like '%" + t + "%'";
                    MySqlDataAdapter a = new MySqlDataAdapter(s, conectar.Conect);
                    a.Fill(tabela);
                    return tabela;
                }
                if (op == "Proprietário")
                {
                    s = "Select *from consulta where proprietario like '%" + t + "%'";
                    MySqlDataAdapter a = new MySqlDataAdapter(s, conectar.Conect);
                    a.Fill(tabela);
                    return tabela;
                }
                if (op == "Animal")
                {
                    s = "Select *from consulta where animal like '%" + t + "%'";
                    MySqlDataAdapter a = new MySqlDataAdapter(s, conectar.Conect);
                    a.Fill(tabela);
                    return tabela;
                }



                return tabela;
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

}
