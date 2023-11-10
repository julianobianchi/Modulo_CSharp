using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeImovel
{
    internal class Imovel
    {
        // declarar os atributos da classe

        public int id, numQuarto, numBanheiro, numGaragem;
        public string tipo, proprietario, endereco;
        public double preco,precoM, areaEmMetrosQuadrados;
       

        // método construtor da Classe
        public Imovel()
        {
            this.id = 0;
            this.tipo = "";
            this.proprietario = "";
            this.endereco = "";
            this.preco = 0;
            this.precoM = 0;
            this.numQuarto = 0;
            this.numBanheiro = 0;
            this.numGaragem = 0;
            this.areaEmMetrosQuadrados = 0;
        }

        // Atributo da Classe Imovel: id
        public void setId(int paraId)
        {
            this.id = paraId;
        }
        public int getId()
        {
            return this.id;
        }
        // Atributo da Classe Imovel: tipo
        public void setTipo(string paraTipo)
        {
            this.tipo = paraTipo;
        }
        public string getTipo()
        {
            return this.tipo;
        }
        // Atributo da Classe Imovel: Proprietario
        public void setProprietario(string paraProprietario)
        {
            this.proprietario = paraProprietario;
        }
        public string getProprietario()
        {
            return this.proprietario;
        }
        // Atributo da Classe Imovel: Endereco
        public void setEndereco(string paraEndereco)
        {
            this.endereco = paraEndereco;
        }
        public string getEndereco()
        {
            return this.endereco;
        }
        // Atributo da Classe Imovel: Preco
        public void setPreco(double paraPreco)
        {
            this.preco = paraPreco;
        }
        public double getPreco()
        {
            return this.preco;
        }
        // Atributo da Classe Imovel: PrecoM
        public void setPrecoM(double paraPrecoM)
        {
            this.precoM = paraPrecoM;
        }
        public double getPrecoM()
        {
            return this.precoM;
        }
        // Atributo da Classe Imovel: NumQuarto
        public void setNumQuarto(int paraNumQuarto)
        {
            this.numQuarto = paraNumQuarto;
        }
        public int getNumQuarto()
        {
            return this.numQuarto;
        }
        // Atributo da Classe Imovel: NumBanheiro
        public void setNumBanheiro(int paraNumBanheiro)
        {
            this.numBanheiro = paraNumBanheiro;
        }
        public int getNumBanheiro()
        {
            return this.numBanheiro;
        }
        // Atributo da Classe Imovel: NumGaragem
        public void setNumGaragem(int paraNumGaragem)
        {
            this.numGaragem = paraNumGaragem;
        }
        public int getNumGaragem()
        {
            return this.numGaragem;
        }
        // Atributo da Classe Imovel: Area em metros quadrado
        public void setArea(double paraArea)
        {
            this.areaEmMetrosQuadrados = paraArea;
        }
        public double getArea()
        {
            return this.areaEmMetrosQuadrados;
        }


        //===========================================================
        // Área dos Métodos  (Ações da Classe)

        // Calcula Preço por Metro Quadrado (Acoes classe)
        public void calcula(double preco, double area)
        {
            
            this.precoM = preco/area;
        }
    }
}
