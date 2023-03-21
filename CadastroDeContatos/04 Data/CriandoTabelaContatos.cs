//using Microsoft.EntityFrameworkCore.Migrations;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Linq;
//using System.Threading.Tasks;

//namespace CadastroDeContatos
//{
//    public partial class CriandoTabelaContatos : Migration
//    {
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.CreateTable(
//                name: "Contatos",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    Nome = table.Column<string>(type:"nvarchar(max", nullable: true),
//                    Email = table.Column<string>(type: "nvarchar(max", nullable: true),
//                    Telefone = table.Column<string>(type: "nvarchar(max", nullable: true),
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Contatos", x => x.Id);
//                });

//        }
//        //protected override void Up([NotNullAttribute] MigrationBuilder migrationBuilder)
//        //{
//        //    throw new NotImplementedException();
//        //}

//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            base.Down(migrationBuilder);
//        }
//    }
//}
