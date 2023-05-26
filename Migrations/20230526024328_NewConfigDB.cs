using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistDist.Migrations
{
    /// <inheritdoc />
    public partial class NewConfigDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Tutores_TutorId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Animals_AnimalId",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Veterinarios_VeterinarioId",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutores_Pessoa_PessoaId",
                table: "Tutores");

            migrationBuilder.DropForeignKey(
                name: "FK_Veterinarios_Pessoa_PessoaId",
                table: "Veterinarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "NotificacaoEmail",
                table: "Veterinarios");

            migrationBuilder.DropColumn(
                name: "NotificacaoWhats",
                table: "Veterinarios");

            migrationBuilder.RenameTable(
                name: "Pessoa",
                newName: "pessoa");

            migrationBuilder.RenameColumn(
                name: "Salario",
                table: "Veterinarios",
                newName: "salario");

            migrationBuilder.RenameColumn(
                name: "PessoaId",
                table: "Veterinarios",
                newName: "Pessoaid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Veterinarios",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PISPasesp",
                table: "Veterinarios",
                newName: "pis_pasesp");

            migrationBuilder.RenameColumn(
                name: "DataDemissao",
                table: "Veterinarios",
                newName: "data_demissao");

            migrationBuilder.RenameColumn(
                name: "DataContratacao",
                table: "Veterinarios",
                newName: "data_contratacao");

            migrationBuilder.RenameColumn(
                name: "CTPSSerie",
                table: "Veterinarios",
                newName: "ctps_serie");

            migrationBuilder.RenameColumn(
                name: "CTPSNumero",
                table: "Veterinarios",
                newName: "ctps_numero");

            migrationBuilder.RenameColumn(
                name: "CTPSEstado",
                table: "Veterinarios",
                newName: "ctps_estado");

            migrationBuilder.RenameColumn(
                name: "CRMVNumero",
                table: "Veterinarios",
                newName: "crmv_numero");

            migrationBuilder.RenameColumn(
                name: "CRMVEstado",
                table: "Veterinarios",
                newName: "crmv_estado");

            migrationBuilder.RenameIndex(
                name: "IX_Veterinarios_PessoaId",
                table: "Veterinarios",
                newName: "IX_Veterinarios_Pessoaid");

            migrationBuilder.RenameColumn(
                name: "PessoaId",
                table: "Tutores",
                newName: "Pessoaid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tutores",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "NotificacaoWhats",
                table: "Tutores",
                newName: "notificacao_whats");

            migrationBuilder.RenameColumn(
                name: "NotificacaoEmail",
                table: "Tutores",
                newName: "notificacao_email");

            migrationBuilder.RenameIndex(
                name: "IX_Tutores_PessoaId",
                table: "Tutores",
                newName: "IX_Tutores_Pessoaid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "pessoa",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "VeterinarioId",
                table: "Consultas",
                newName: "Veterinarioid");

            migrationBuilder.RenameColumn(
                name: "Diagnostico",
                table: "Consultas",
                newName: "diagnostico");

            migrationBuilder.RenameColumn(
                name: "AnimalId",
                table: "Consultas",
                newName: "Animalid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Consultas",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ValorConsulta",
                table: "Consultas",
                newName: "valor_consulta");

            migrationBuilder.RenameColumn(
                name: "HorarioConsulta",
                table: "Consultas",
                newName: "horario_consulta");

            migrationBuilder.RenameColumn(
                name: "DataConsulta",
                table: "Consultas",
                newName: "data_consulta");

            migrationBuilder.RenameColumn(
                name: "DataCadastro",
                table: "Consultas",
                newName: "data_cadastro");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_VeterinarioId",
                table: "Consultas",
                newName: "IX_Consultas_Veterinarioid");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_AnimalId",
                table: "Consultas",
                newName: "IX_Consultas_Animalid");

            migrationBuilder.RenameColumn(
                name: "TutorId",
                table: "Animals",
                newName: "Tutorid");

            migrationBuilder.RenameColumn(
                name: "Sexo",
                table: "Animals",
                newName: "sexo");

            migrationBuilder.RenameColumn(
                name: "Raca",
                table: "Animals",
                newName: "raca");

            migrationBuilder.RenameColumn(
                name: "Peso",
                table: "Animals",
                newName: "peso");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Animals",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Especie",
                table: "Animals",
                newName: "especie");

            migrationBuilder.RenameColumn(
                name: "Cor",
                table: "Animals",
                newName: "cor");

            migrationBuilder.RenameColumn(
                name: "Alergia",
                table: "Animals",
                newName: "alergia");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Animals",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "Animals",
                newName: "data_nascimento");

            migrationBuilder.RenameColumn(
                name: "DataCadastro",
                table: "Animals",
                newName: "data_cadastro");

            migrationBuilder.RenameIndex(
                name: "IX_Animals_TutorId",
                table: "Animals",
                newName: "IX_Animals_Tutorid");

            migrationBuilder.AddColumn<int>(
                name: "pessoa_id",
                table: "Veterinarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "pessoa_id",
                table: "Tutores",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "animal_id",
                table: "Consultas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "veterinario_id",
                table: "Consultas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tutor_id",
                table: "Animals",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_pessoa",
                table: "pessoa",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Tutores_Tutorid",
                table: "Animals",
                column: "Tutorid",
                principalTable: "Tutores",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Animals_Animalid",
                table: "Consultas",
                column: "Animalid",
                principalTable: "Animals",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Veterinarios_Veterinarioid",
                table: "Consultas",
                column: "Veterinarioid",
                principalTable: "Veterinarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tutores_pessoa_Pessoaid",
                table: "Tutores",
                column: "Pessoaid",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veterinarios_pessoa_Pessoaid",
                table: "Veterinarios",
                column: "Pessoaid",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Tutores_Tutorid",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Animals_Animalid",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Veterinarios_Veterinarioid",
                table: "Consultas");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutores_pessoa_Pessoaid",
                table: "Tutores");

            migrationBuilder.DropForeignKey(
                name: "FK_Veterinarios_pessoa_Pessoaid",
                table: "Veterinarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pessoa",
                table: "pessoa");

            migrationBuilder.DropColumn(
                name: "pessoa_id",
                table: "Veterinarios");

            migrationBuilder.DropColumn(
                name: "pessoa_id",
                table: "Tutores");

            migrationBuilder.DropColumn(
                name: "animal_id",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "veterinario_id",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "tutor_id",
                table: "Animals");

            migrationBuilder.RenameTable(
                name: "pessoa",
                newName: "Pessoa");

            migrationBuilder.RenameColumn(
                name: "salario",
                table: "Veterinarios",
                newName: "Salario");

            migrationBuilder.RenameColumn(
                name: "Pessoaid",
                table: "Veterinarios",
                newName: "PessoaId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Veterinarios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "pis_pasesp",
                table: "Veterinarios",
                newName: "PISPasesp");

            migrationBuilder.RenameColumn(
                name: "data_demissao",
                table: "Veterinarios",
                newName: "DataDemissao");

            migrationBuilder.RenameColumn(
                name: "data_contratacao",
                table: "Veterinarios",
                newName: "DataContratacao");

            migrationBuilder.RenameColumn(
                name: "ctps_serie",
                table: "Veterinarios",
                newName: "CTPSSerie");

            migrationBuilder.RenameColumn(
                name: "ctps_numero",
                table: "Veterinarios",
                newName: "CTPSNumero");

            migrationBuilder.RenameColumn(
                name: "ctps_estado",
                table: "Veterinarios",
                newName: "CTPSEstado");

            migrationBuilder.RenameColumn(
                name: "crmv_numero",
                table: "Veterinarios",
                newName: "CRMVNumero");

            migrationBuilder.RenameColumn(
                name: "crmv_estado",
                table: "Veterinarios",
                newName: "CRMVEstado");

            migrationBuilder.RenameIndex(
                name: "IX_Veterinarios_Pessoaid",
                table: "Veterinarios",
                newName: "IX_Veterinarios_PessoaId");

            migrationBuilder.RenameColumn(
                name: "Pessoaid",
                table: "Tutores",
                newName: "PessoaId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Tutores",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "notificacao_whats",
                table: "Tutores",
                newName: "NotificacaoWhats");

            migrationBuilder.RenameColumn(
                name: "notificacao_email",
                table: "Tutores",
                newName: "NotificacaoEmail");

            migrationBuilder.RenameIndex(
                name: "IX_Tutores_Pessoaid",
                table: "Tutores",
                newName: "IX_Tutores_PessoaId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Pessoa",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "diagnostico",
                table: "Consultas",
                newName: "Diagnostico");

            migrationBuilder.RenameColumn(
                name: "Veterinarioid",
                table: "Consultas",
                newName: "VeterinarioId");

            migrationBuilder.RenameColumn(
                name: "Animalid",
                table: "Consultas",
                newName: "AnimalId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Consultas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "valor_consulta",
                table: "Consultas",
                newName: "ValorConsulta");

            migrationBuilder.RenameColumn(
                name: "horario_consulta",
                table: "Consultas",
                newName: "HorarioConsulta");

            migrationBuilder.RenameColumn(
                name: "data_consulta",
                table: "Consultas",
                newName: "DataConsulta");

            migrationBuilder.RenameColumn(
                name: "data_cadastro",
                table: "Consultas",
                newName: "DataCadastro");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_Veterinarioid",
                table: "Consultas",
                newName: "IX_Consultas_VeterinarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_Animalid",
                table: "Consultas",
                newName: "IX_Consultas_AnimalId");

            migrationBuilder.RenameColumn(
                name: "sexo",
                table: "Animals",
                newName: "Sexo");

            migrationBuilder.RenameColumn(
                name: "raca",
                table: "Animals",
                newName: "Raca");

            migrationBuilder.RenameColumn(
                name: "peso",
                table: "Animals",
                newName: "Peso");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Animals",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "especie",
                table: "Animals",
                newName: "Especie");

            migrationBuilder.RenameColumn(
                name: "cor",
                table: "Animals",
                newName: "Cor");

            migrationBuilder.RenameColumn(
                name: "alergia",
                table: "Animals",
                newName: "Alergia");

            migrationBuilder.RenameColumn(
                name: "Tutorid",
                table: "Animals",
                newName: "TutorId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Animals",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "data_nascimento",
                table: "Animals",
                newName: "DataNascimento");

            migrationBuilder.RenameColumn(
                name: "data_cadastro",
                table: "Animals",
                newName: "DataCadastro");

            migrationBuilder.RenameIndex(
                name: "IX_Animals_Tutorid",
                table: "Animals",
                newName: "IX_Animals_TutorId");

            migrationBuilder.AddColumn<bool>(
                name: "NotificacaoEmail",
                table: "Veterinarios",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NotificacaoWhats",
                table: "Veterinarios",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Tutores_TutorId",
                table: "Animals",
                column: "TutorId",
                principalTable: "Tutores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Animals_AnimalId",
                table: "Consultas",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Veterinarios_VeterinarioId",
                table: "Consultas",
                column: "VeterinarioId",
                principalTable: "Veterinarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tutores_Pessoa_PessoaId",
                table: "Tutores",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veterinarios_Pessoa_PessoaId",
                table: "Veterinarios",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
