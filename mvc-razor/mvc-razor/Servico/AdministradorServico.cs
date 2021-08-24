﻿using mvc_razor.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace mvc_razor.Servico
{
    public class AdministradorServico
    {
        public static async Task<List<Administrador>> Todos(int pagina = 1)
        {
            return (await TodosPaginado(pagina)).Results;
        }

        public static async Task<PaginacaoAdm> TodosPaginado(int pagina = 1)
        {
            using (var http = new HttpClient())
            {
                using (var response = await http.GetAsync($"{Program.AdministradoresAPI}/administradores?page={pagina}"))
                {
                    if (!response.IsSuccessStatusCode) return new PaginacaoAdm();

                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<PaginacaoAdm>(json);
                }
            }
        }

        public static async Task<Administrador> BuscarPorId(int id)
        {
            using (var http = new HttpClient())
            {
                using (var response = await http.GetAsync($"{Program.AdministradoresAPI}/administradores/{id}"))
                {
                    if (!response.IsSuccessStatusCode) return null;
                    return JsonConvert.DeserializeObject<Administrador>(await response.Content.ReadAsStringAsync());
                }
            }
        }

        public static async Task<Administrador> Salvar(Administrador administrador)
        {
            using (var http = new HttpClient())
            {
                if (administrador.Id == 0)
                {
                    using (var response = await http.PostAsJsonAsync($"{Program.AdministradoresAPI}/administradores", administrador))
                    {
                        string retorno = await response.Content.ReadAsStringAsync();
                        if (!response.IsSuccessStatusCode)
                        {
                            Console.WriteLine("========================");
                            Console.WriteLine(retorno);
                            Console.WriteLine("========================");
                            throw new Exception("Erro ao incluir na API");
                        }
                        return JsonConvert.DeserializeObject<Administrador>(retorno);
                    }
                }
                else
                {
                    using (var response = await http.PutAsJsonAsync($"{Program.AdministradoresAPI}/administradores/{administrador.Id}", administrador))
                    {
                        if (!response.IsSuccessStatusCode) throw new Exception("Erro ao atualizar na API");
                        return JsonConvert.DeserializeObject<Administrador>(await response.Content.ReadAsStringAsync());
                    }
                }
            }
        }

        public static async Task ExcluirPorId(int id)
        {
            using (var http = new HttpClient())
            {
                using (var response = await http.DeleteAsync($"{Program.AdministradoresAPI}/administradores/{id}"))
                {
                    if (!response.IsSuccessStatusCode) throw new Exception("Erro ao excluir da API");
                }
            }
        }

    }
}
