using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TreinamentoLinq.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banco",
                columns: table => new
                {
                    codigoBanco = table.Column<string>(type: "varchar(3)", nullable: false),
                    nomeBanco = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_banco", x => x.codigoBanco);
                });

            migrationBuilder.CreateTable(
                name: "BandeiraCartao",
                columns: table => new
                {
                    idBandeiraCartao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeBandeira = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_bandeiraCartao", x => x.idBandeiraCartao);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    idEmpresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNPJ = table.Column<string>(type: "varchar(14)", nullable: false),
                    razaoSocial = table.Column<string>(type: "varchar(100)", nullable: false),
                    nomeFantasia = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_empresa", x => x.idEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "MeioPagamento",
                columns: table => new
                {
                    idMeioPagamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeMeioPagamento = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_meioPagamento", x => x.idMeioPagamento);
                });

            migrationBuilder.CreateTable(
                name: "OperadoraCartao",
                columns: table => new
                {
                    idOperadoraCartao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeOperadoraCartao = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_operadoraCartao", x => x.idOperadoraCartao);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeCliente = table.Column<string>(type: "varchar(100)", nullable: false),
                    idEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cliente", x => x.idCliente);
                    table.ForeignKey(
                        name: "fk_cliente_empresa",
                        column: x => x.idEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "idEmpresa");
                });

            migrationBuilder.CreateTable(
                name: "ContaFinanceira",
                columns: table => new
                {
                    idContaFinanceira = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeContaFinanceira = table.Column<string>(type: "varchar(100)", nullable: false),
                    isContaCaixa = table.Column<bool>(type: "bit", nullable: false),
                    agencia = table.Column<string>(type: "varchar(20)", nullable: false),
                    numeroConta = table.Column<string>(type: "varchar(20)", nullable: false),
                    codigoBanco = table.Column<string>(type: "varchar(3)", nullable: true),
                    idEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_contaFinanceira", x => x.idContaFinanceira);
                    table.ForeignKey(
                        name: "fk_contaFinanceira_banco",
                        column: x => x.codigoBanco,
                        principalTable: "Banco",
                        principalColumn: "codigoBanco");
                    table.ForeignKey(
                        name: "fk_contaFinanceira_empresa",
                        column: x => x.idEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "idEmpresa");
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    idProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeProduto = table.Column<string>(type: "varchar(100)", nullable: false),
                    quantidadeEstoque = table.Column<int>(type: "int", nullable: false),
                    valorVenda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valorPromocional = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    idEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_produto", x => x.idProduto);
                    table.ForeignKey(
                        name: "fk_produto_empresa",
                        column: x => x.idEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "idEmpresa");
                });

            migrationBuilder.CreateTable(
                name: "TaxaBandeiraOperadoraCartao",
                columns: table => new
                {
                    idEmpresa = table.Column<int>(type: "int", nullable: false),
                    idBandeiraCartao = table.Column<int>(type: "int", nullable: false),
                    idOperadoraCartao = table.Column<int>(type: "int", nullable: false),
                    percentualTaxaCartao = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_taxaBandeiraOperadoraCartao", x => new { x.idEmpresa, x.idBandeiraCartao, x.idOperadoraCartao });
                    table.ForeignKey(
                        name: "fk_taxaBandeiraOperadoraCartao_bandeiraCartao",
                        column: x => x.idBandeiraCartao,
                        principalTable: "BandeiraCartao",
                        principalColumn: "idBandeiraCartao");
                    table.ForeignKey(
                        name: "fk_taxaBandeiraOperadoraCartao_empresa",
                        column: x => x.idEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "idEmpresa");
                    table.ForeignKey(
                        name: "fk_taxaBandeiraOperadoraCartao_operadoraCartao",
                        column: x => x.idOperadoraCartao,
                        principalTable: "OperadoraCartao",
                        principalColumn: "idOperadoraCartao");
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    idPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valorTotalPedido = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valorTotalDesconto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valorFinalPedido = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dataPedido = table.Column<DateTime>(type: "datetime", nullable: false),
                    isPago = table.Column<bool>(type: "bit", nullable: false),
                    valorPagoMomento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dataPrimeiroPagamento = table.Column<DateTime>(type: "datetime", nullable: true),
                    idCliente = table.Column<int>(type: "int", nullable: false),
                    idEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pedido", x => x.idPedido);
                    table.ForeignKey(
                        name: "fk_pedido_cliente",
                        column: x => x.idCliente,
                        principalTable: "Cliente",
                        principalColumn: "idCliente");
                    table.ForeignKey(
                        name: "fk_pedido_empresa",
                        column: x => x.idEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "idEmpresa");
                });

            migrationBuilder.CreateTable(
                name: "PedidoItem",
                columns: table => new
                {
                    idItemPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    valorUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valorDesconto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valorFinal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    idProduto = table.Column<int>(type: "int", nullable: false),
                    idPedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pedidoItem", x => x.idItemPedido);
                    table.ForeignKey(
                        name: "fk_pedidoItem_pedido",
                        column: x => x.idPedido,
                        principalTable: "Pedido",
                        principalColumn: "idPedido");
                    table.ForeignKey(
                        name: "fk_pedidoItem_produto",
                        column: x => x.idProduto,
                        principalTable: "Produto",
                        principalColumn: "idProduto");
                });

            migrationBuilder.CreateTable(
                name: "PedidoPagamento",
                columns: table => new
                {
                    idPagamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataPagamento = table.Column<DateTime>(type: "datetime", nullable: false),
                    valorPagamento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valorJuros = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valorMulta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    valorDescontoPagamento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dataPrevistaCredito = table.Column<DateTime>(type: "datetime", nullable: false),
                    numeroParcela = table.Column<int>(type: "int", nullable: false),
                    quantidadeParcela = table.Column<int>(type: "int", nullable: false),
                    codigoPagamento = table.Column<string>(type: "varchar(100)", nullable: false),
                    idMeioPagamento = table.Column<int>(type: "int", nullable: false),
                    idBandeira = table.Column<int>(type: "int", nullable: true),
                    idOperadoraCartao = table.Column<int>(type: "int", nullable: true),
                    idContaFinanceira = table.Column<int>(type: "int", nullable: false),
                    idPedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pedidoPagamento", x => x.idPagamento);
                    table.ForeignKey(
                        name: "fk_pedidoPagamento_bandeiraCartao",
                        column: x => x.idBandeira,
                        principalTable: "BandeiraCartao",
                        principalColumn: "idBandeiraCartao");
                    table.ForeignKey(
                        name: "fk_pedidoPagamento_contaFinanceira",
                        column: x => x.idContaFinanceira,
                        principalTable: "ContaFinanceira",
                        principalColumn: "idContaFinanceira");
                    table.ForeignKey(
                        name: "fk_pedidoPagamento_meioPagamento",
                        column: x => x.idMeioPagamento,
                        principalTable: "MeioPagamento",
                        principalColumn: "idMeioPagamento");
                    table.ForeignKey(
                        name: "fk_pedidoPagamento_operadoraCartao",
                        column: x => x.idOperadoraCartao,
                        principalTable: "OperadoraCartao",
                        principalColumn: "idOperadoraCartao");
                    table.ForeignKey(
                        name: "fk_pedidoPagamento_pedido",
                        column: x => x.idPedido,
                        principalTable: "Pedido",
                        principalColumn: "idPedido");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_idEmpresa",
                table: "Cliente",
                column: "idEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_ContaFinanceira_codigoBanco",
                table: "ContaFinanceira",
                column: "codigoBanco");

            migrationBuilder.CreateIndex(
                name: "IX_ContaFinanceira_idEmpresa",
                table: "ContaFinanceira",
                column: "idEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_idCliente",
                table: "Pedido",
                column: "idCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_idEmpresa",
                table: "Pedido",
                column: "idEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItem_idPedido",
                table: "PedidoItem",
                column: "idPedido");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItem_idProduto",
                table: "PedidoItem",
                column: "idProduto");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoPagamento_idBandeira",
                table: "PedidoPagamento",
                column: "idBandeira");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoPagamento_idContaFinanceira",
                table: "PedidoPagamento",
                column: "idContaFinanceira");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoPagamento_idMeioPagamento",
                table: "PedidoPagamento",
                column: "idMeioPagamento");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoPagamento_idOperadoraCartao",
                table: "PedidoPagamento",
                column: "idOperadoraCartao");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoPagamento_idPedido",
                table: "PedidoPagamento",
                column: "idPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_idEmpresa",
                table: "Produto",
                column: "idEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_TaxaBandeiraOperadoraCartao_idBandeiraCartao",
                table: "TaxaBandeiraOperadoraCartao",
                column: "idBandeiraCartao");

            migrationBuilder.CreateIndex(
                name: "IX_TaxaBandeiraOperadoraCartao_idOperadoraCartao",
                table: "TaxaBandeiraOperadoraCartao",
                column: "idOperadoraCartao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidoItem");

            migrationBuilder.DropTable(
                name: "PedidoPagamento");

            migrationBuilder.DropTable(
                name: "TaxaBandeiraOperadoraCartao");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "ContaFinanceira");

            migrationBuilder.DropTable(
                name: "MeioPagamento");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "BandeiraCartao");

            migrationBuilder.DropTable(
                name: "OperadoraCartao");

            migrationBuilder.DropTable(
                name: "Banco");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
