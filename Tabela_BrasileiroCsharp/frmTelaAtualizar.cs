using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabela_BrasileiroCsharp
{
    public partial class frmTelaAtualizar : Form
    {
        private List<dynamic> listaClubes = new List<dynamic>();
        public frmTelaAtualizar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbSerie_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void Get()
        {
            throw new NotImplementedException();
        }

        private async void cdSerie_SelectedValueChanged(object sender, EventArgs e)
        {
            string serie = cdSerie.Text;

            switch (serie)
            {
                case "Série A":
                    await SerieA();
                    break;
                case "Série B":
                    await SerieB();
                    break;
                case "Série C":
                    await SerieC();
                    break;
                case "Série D":
                    await SerieD();
                    break;
                default:
                    MessageBox.Show("Selecione a série.");
                    break;
            }
        }

        private async Task SerieD()
        {
            string apiUrl = ApiRotasController.ConsultarSerieD;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieDModel>>(jsonString);

                        listaClubes = dados.Cast<dynamic>().ToList();

                        dgvAtualizar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async Task SerieC()
        {
            string apiUrl = ApiRotasController.ConsultarSerieC;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieCModel>>(jsonString);

                        listaClubes = dados.Cast<dynamic>().ToList();

                        dgvAtualizar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async Task SerieB()
        {
            string apiUrl = ApiRotasController.ConsultarSerieB;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieBModel>>(jsonString);

                        listaClubes = dados.Cast<dynamic>().ToList();

                        dgvAtualizar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async Task SerieA()
        {
            string apiUrl = ApiRotasController.ConsultarSerieA;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieAModel>>(jsonString);

                        listaClubes = dados.Cast<dynamic>().ToList();

                        dgvAtualizar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private int idSelecionado;
        private void dgvAtualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string serie = cdSerie.Text;

                switch (serie)
                {
                    case "Série A":
                        idSelecionado = Convert.ToInt32(dgvAtualizar.Rows[e.RowIndex].Cells["idSerieA"].Value);
                        break;
                    case "Série B":
                        idSelecionado = Convert.ToInt32(dgvAtualizar.Rows[e.RowIndex].Cells["idSerieB"].Value);
                        break;
                    case "Série C":
                        idSelecionado = Convert.ToInt32(dgvAtualizar.Rows[e.RowIndex].Cells["idSerieC"].Value);
                        break;
                    case "Série D":
                        idSelecionado = Convert.ToInt32(dgvAtualizar.Rows[e.RowIndex].Cells["idSerieD"].Value);
                        break;
                    default:
                        MessageBox.Show("Selecione a série.");
                        break;
                }

                txtNomeTime.Text = dgvAtualizar.Rows[e.RowIndex].Cells["NomeClube"].Value.ToString();
                txtPontosTime.Text = dgvAtualizar.Rows[e.RowIndex].Cells["PontosClube"].Value.ToString();
                txtJogosClube.Text = dgvAtualizar.Rows[e.RowIndex].Cells["JogosClube"].Value.ToString();
                txtSaldoGols.Text = dgvAtualizar.Rows[e.RowIndex].Cells["SaldoGols"].Value.ToString();
                txtVitoriasClube.Text = dgvAtualizar.Rows[e.RowIndex].Cells["VitoriasClube"].Value.ToString();
                txtDerrotasClube.Text = dgvAtualizar.Rows[e.RowIndex].Cells["DerrotasClube"].Value.ToString();
                txtPosicaoClube.Text = dgvAtualizar.Rows[e.RowIndex].Cells["PosicaoTabela"].Value.ToString();
            }


        }

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            string serie = cdSerie.Text;

            switch (serie)
            {
                case "Série A":
                    await AtualizarSerieA();
                    break;
                case "Série B":
                    await AtualizarSerieB();
                    break;
                case "Série C":
                    await AtualizarSerieC();
                    break;
                case "Série D":
                    await AtualizarSerieD();
                    break;
                default:
                    MessageBox.Show("Selecione a série.");
                    break;
            }
        }

        private async Task AtualizarSerieD()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var serie = new ConsultarSerieDModel()
                    {
                        IdSerieD = idSelecionado,
                        NomeClube = txtNomeTime.Text,
                        PontosClube = Convert.ToInt32(txtPontosTime.Text),
                        JogosClube = Convert.ToInt32(txtJogosClube.Text),
                        SaldoGols = Convert.ToInt32(txtSaldoGols.Text),
                        VitoriasClube = Convert.ToInt32(txtVitoriasClube.Text),
                        DerrotasClube = Convert.ToInt32(txtDerrotasClube.Text),
                        PosicaoTabela = Convert.ToInt32(txtPosicaoClube.Text)
                    };

                    string json = JsonConvert.SerializeObject(serie);

                    StringContent content = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json");

                    HttpResponseMessage response = await client.PutAsync(
                        $"{ApiRotasController.AtualizarSerieD}/{idSelecionado}",
                        content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro atualizado com sucesso!");

                        await SerieD(); // Atualiza a DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Erro: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private async Task AtualizarSerieC()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var serie = new ConsultarSerieCModel()
                    {
                        IdSerieC = idSelecionado,
                        NomeClube = txtNomeTime.Text,
                        PontosClube = Convert.ToInt32(txtPontosTime.Text),
                        JogosClube = Convert.ToInt32(txtJogosClube.Text),
                        SaldoGols = Convert.ToInt32(txtSaldoGols.Text),
                        VitoriasClube = Convert.ToInt32(txtVitoriasClube.Text),
                        DerrotasClube = Convert.ToInt32(txtDerrotasClube.Text),
                        PosicaoTabela = Convert.ToInt32(txtPosicaoClube.Text)
                    };

                    string json = JsonConvert.SerializeObject(serie);

                    StringContent content = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json");

                    HttpResponseMessage response = await client.PutAsync(
                        $"{ApiRotasController.AtualizarSerieC}/{idSelecionado}",
                        content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro atualizado com sucesso!");

                        await SerieC(); // Atualiza a DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Erro: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private async Task AtualizarSerieB()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var serie = new ConsultarSerieBModel()
                    {
                        IdSerieB = idSelecionado,
                        NomeClube = txtNomeTime.Text,
                        PontosClube = Convert.ToInt32(txtPontosTime.Text),
                        JogosClube = Convert.ToInt32(txtJogosClube.Text),
                        SaldoGols = Convert.ToInt32(txtSaldoGols.Text),
                        VitoriasClube = Convert.ToInt32(txtVitoriasClube.Text),
                        DerrotasClube = Convert.ToInt32(txtDerrotasClube.Text),
                        PosicaoTabela = Convert.ToInt32(txtPosicaoClube.Text)
                    };

                    string json = JsonConvert.SerializeObject(serie);

                    StringContent content = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json");

                    HttpResponseMessage response = await client.PutAsync(
                        $"{ApiRotasController.AtualizarSerieB}/{idSelecionado}",
                        content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro atualizado com sucesso!");

                        await SerieB(); // Atualiza a DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Erro: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private async Task AtualizarSerieA()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var serie = new ConsultarSerieAModel()
                    {
                        IdSerieA = idSelecionado,
                        NomeClube = txtNomeTime.Text,
                        PontosClube = Convert.ToInt32(txtPontosTime.Text),
                        JogosClube = Convert.ToInt32(txtJogosClube.Text),
                        SaldoGols = Convert.ToInt32(txtSaldoGols.Text),
                        VitoriasClube = Convert.ToInt32(txtVitoriasClube.Text),
                        DerrotasClube = Convert.ToInt32(txtDerrotasClube.Text),
                        PosicaoTabela = Convert.ToInt32(txtPosicaoClube.Text)
                    };

                    string json = JsonConvert.SerializeObject(serie);

                    StringContent content = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json");

                    HttpResponseMessage response = await client.PutAsync(
                        $"{ApiRotasController.AtualizarSerieA}/{idSelecionado}",
                        content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro atualizado com sucesso!");

                        await SerieA(); // Atualiza a DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Erro: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }


        }

        private async void btnApagar_Click(object sender, EventArgs e)
        {
            string serie = cdSerie.Text;
            switch (serie)
            {
                case "Série A":
                    await DeletarSerieA();
                    break;
                case "Série B":
                    await DeletarSerieB();
                    break;
                case "Série C":
                    await DeletarSerieC();
                    break;
                case "Série D":
                    await DeletarSerieD();
                    break;
                default:
                    MessageBox.Show("Selecione a série.");
                    break;
            }
        }

        private async Task DeletarSerieD()
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um registro para excluir.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Deseja realmente excluir este registro?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.DeleteAsync(
                            $"{ApiRotasController.DeletarSerieD}/{idSelecionado}");

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Registro excluído com sucesso!");

                            idSelecionado = 0;

                            txtNomeTime.Clear();
                            txtPontosTime.Clear();
                            txtJogosClube.Clear();
                            txtSaldoGols.Clear();
                            txtVitoriasClube.Clear();
                            txtDerrotasClube.Clear();
                            txtPosicaoClube.Clear();

                            await SerieD(); // Atualiza a DataGridView
                        }
                        else
                        {
                            string erro = await response.Content.ReadAsStringAsync();

                            MessageBox.Show(
                                $"Erro: {(int)response.StatusCode}\n{erro}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }


        private async Task DeletarSerieC()
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um registro para excluir.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Deseja realmente excluir este registro?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.DeleteAsync(
                            $"{ApiRotasController.DeletarSerieC}/{idSelecionado}");

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Registro excluído com sucesso!");

                            idSelecionado = 0;

                            txtNomeTime.Clear();
                            txtPontosTime.Clear();
                            txtJogosClube.Clear();
                            txtSaldoGols.Clear();
                            txtVitoriasClube.Clear();
                            txtDerrotasClube.Clear();
                            txtPosicaoClube.Clear();

                            await SerieC(); // Atualiza a DataGridView
                        }
                        else
                        {
                            string erro = await response.Content.ReadAsStringAsync();

                            MessageBox.Show(
                                $"Erro: {(int)response.StatusCode}\n{erro}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }


        private async Task DeletarSerieB()
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um registro para excluir.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Deseja realmente excluir este registro?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.DeleteAsync(
                            $"{ApiRotasController.DeletarSerieB}/{idSelecionado}");

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Registro excluído com sucesso!");

                            idSelecionado = 0;

                            txtNomeTime.Clear();
                            txtPontosTime.Clear();
                            txtJogosClube.Clear();
                            txtSaldoGols.Clear();
                            txtVitoriasClube.Clear();
                            txtDerrotasClube.Clear();
                            txtPosicaoClube.Clear();

                            await SerieB(); // Atualiza a DataGridView
                        }
                        else
                        {
                            string erro = await response.Content.ReadAsStringAsync();

                            MessageBox.Show(
                                $"Erro: {(int)response.StatusCode}\n{erro}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }

        private async Task DeletarSerieA()
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um registro para excluir.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Deseja realmente excluir este registro?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.DeleteAsync(
                            $"{ApiRotasController.DeletarSerieA}/{idSelecionado}");

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Registro excluído com sucesso!");

                            idSelecionado = 0;

                            txtNomeTime.Clear();
                            txtPontosTime.Clear();
                            txtJogosClube.Clear();
                            txtSaldoGols.Clear();
                            txtVitoriasClube.Clear();
                            txtDerrotasClube.Clear();
                            txtPosicaoClube.Clear();

                            await SerieA(); // Atualiza a DataGridView
                        }
                        else
                        {
                            string erro = await response.Content.ReadAsStringAsync();

                            MessageBox.Show(
                                $"Erro: {(int)response.StatusCode}\n{erro}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }

        private async void btnInserir_Click(object sender, EventArgs e)
        {
            string serie = cdSerie.Text;

            switch (serie)
            {
                case "Série A":
                    await InserirSerieA();
                    break;

                case "Série B":
                    await InserirSerieB();
                    break;

                case "Série C":
                    await InserirSerieC();
                    break;

                case "Série D":
                    await InserirSerieD();
                    break;

                default:
                    MessageBox.Show("Selecione a série.");
                    break;
            }
        }

        private async Task InserirSerieD()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var serie = new ConsultarSerieDModel()
                    {
                        NomeClube = txtNomeTime.Text,
                        PontosClube = Convert.ToInt32(txtPontosTime.Text),
                        JogosClube = Convert.ToInt32(txtJogosClube.Text),
                        SaldoGols = Convert.ToInt32(txtSaldoGols.Text),
                        VitoriasClube = Convert.ToInt32(txtVitoriasClube.Text),
                        DerrotasClube = Convert.ToInt32(txtDerrotasClube.Text),
                        PosicaoTabela = Convert.ToInt32(txtPosicaoClube.Text)
                    };

                    string json = JsonConvert.SerializeObject(serie);

                    StringContent content = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json");

                    HttpResponseMessage response = await client.PostAsync(
                        ApiRotasController.InserirSerieD,
                        content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro inserido com sucesso!");

                        txtNomeTime.Clear();
                        txtPontosTime.Clear();
                        txtJogosClube.Clear();
                        txtSaldoGols.Clear();
                        txtVitoriasClube.Clear();
                        txtDerrotasClube.Clear();
                        txtPosicaoClube.Clear();

                        await SerieD();
                    }
                    else
                    {
                        string erro = await response.Content.ReadAsStringAsync();

                        MessageBox.Show($"Erro: {(int)response.StatusCode}\n{erro}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private async Task InserirSerieC()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var serie = new ConsultarSerieCModel()
                    {
                        NomeClube = txtNomeTime.Text,
                        PontosClube = Convert.ToInt32(txtPontosTime.Text),
                        JogosClube = Convert.ToInt32(txtJogosClube.Text),
                        SaldoGols = Convert.ToInt32(txtSaldoGols.Text),
                        VitoriasClube = Convert.ToInt32(txtVitoriasClube.Text),
                        DerrotasClube = Convert.ToInt32(txtDerrotasClube.Text),
                        PosicaoTabela = Convert.ToInt32(txtPosicaoClube.Text)
                    };

                    string json = JsonConvert.SerializeObject(serie);

                    StringContent content = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json");

                    HttpResponseMessage response = await client.PostAsync(
                        ApiRotasController.InserirSerieC,
                        content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro inserido com sucesso!");

                        txtNomeTime.Clear();
                        txtPontosTime.Clear();
                        txtJogosClube.Clear();
                        txtSaldoGols.Clear();
                        txtVitoriasClube.Clear();
                        txtDerrotasClube.Clear();
                        txtPosicaoClube.Clear();

                        await SerieC();
                    }
                    else
                    {
                        string erro = await response.Content.ReadAsStringAsync();

                        MessageBox.Show($"Erro: {(int)response.StatusCode}\n{erro}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private async Task InserirSerieB()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var serie = new ConsultarSerieBModel()
                    {
                        NomeClube = txtNomeTime.Text,
                        PontosClube = Convert.ToInt32(txtPontosTime.Text),
                        JogosClube = Convert.ToInt32(txtJogosClube.Text),
                        SaldoGols = Convert.ToInt32(txtSaldoGols.Text),
                        VitoriasClube = Convert.ToInt32(txtVitoriasClube.Text),
                        DerrotasClube = Convert.ToInt32(txtDerrotasClube.Text),
                        PosicaoTabela = Convert.ToInt32(txtPosicaoClube.Text)
                    };

                    string json = JsonConvert.SerializeObject(serie);

                    StringContent content = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json");

                    HttpResponseMessage response = await client.PostAsync(
                        ApiRotasController.InserirSerieB,
                        content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro inserido com sucesso!");

                        txtNomeTime.Clear();
                        txtPontosTime.Clear();
                        txtJogosClube.Clear();
                        txtSaldoGols.Clear();
                        txtVitoriasClube.Clear();
                        txtDerrotasClube.Clear();
                        txtPosicaoClube.Clear();

                        await SerieB();
                    }
                    else
                    {
                        string erro = await response.Content.ReadAsStringAsync();

                        MessageBox.Show($"Erro: {(int)response.StatusCode}\n{erro}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private async Task InserirSerieA()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var serie = new ConsultarSerieAModel()
                    {
                        NomeClube = txtNomeTime.Text,
                        PontosClube = Convert.ToInt32(txtPontosTime.Text),
                        JogosClube = Convert.ToInt32(txtJogosClube.Text),
                        SaldoGols = Convert.ToInt32(txtSaldoGols.Text),
                        VitoriasClube = Convert.ToInt32(txtVitoriasClube.Text),
                        DerrotasClube = Convert.ToInt32(txtDerrotasClube.Text),
                        PosicaoTabela = Convert.ToInt32(txtPosicaoClube.Text)
                    };

                    string json = JsonConvert.SerializeObject(serie);

                    StringContent content = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json");

                    HttpResponseMessage response = await client.PostAsync(
                        ApiRotasController.InserirSerieA,
                        content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro inserido com sucesso!");

                        txtNomeTime.Clear();
                        txtPontosTime.Clear();
                        txtJogosClube.Clear();
                        txtSaldoGols.Clear();
                        txtVitoriasClube.Clear();
                        txtDerrotasClube.Clear();
                        txtPosicaoClube.Clear();

                        await SerieA();
                    }
                    else
                    {
                        string erro = await response.Content.ReadAsStringAsync();

                        MessageBox.Show($"Erro: {(int)response.StatusCode}\n{erro}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txbBuscar.Text.ToLower();

            if (string.IsNullOrWhiteSpace(pesquisa))
            {
                dgvAtualizar.DataSource = listaClubes;
                return;
            }

            if (rbNomeTime.Checked)
            {
                dgvAtualizar.DataSource = listaClubes
                    .Where(x => x.NomeClube.ToLower().Contains(pesquisa))
                    .ToList();
            }
            else if (rbPosicaoClube.Checked)
            {
                dgvAtualizar.DataSource = listaClubes
                    .Where(x => x.PosicaoTabela.ToString().Contains(pesquisa))
                    .ToList();
            }
        }
    }
}

