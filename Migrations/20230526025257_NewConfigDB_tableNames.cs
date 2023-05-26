using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistDist.Migrations
{
    /// <inheritdoc />
    public partial class NewConfigDB_tableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "PK_Veterinarios",
                table: "Veterinarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tutores",
                table: "Tutores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Consultas",
                table: "Consultas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Animals",
                table: "Animals");

            migrationBuilder.RenameTable(
                name: "Veterinarios",
                newName: "veterinario");

            migrationBuilder.RenameTable(
                name: "Tutores",
                newName: "tutor");

            migrationBuilder.RenameTable(
                name: "Consultas",
                newName: "consulta");

            migrationBuilder.RenameTable(
                name: "Animals",
                newName: "animal");

            migrationBuilder.RenameIndex(
                name: "IX_Veterinarios_Pessoaid",
                table: "veterinario",
                newName: "IX_veterinario_Pessoaid");

            migrationBuilder.RenameIndex(
                name: "IX_Tutores_Pessoaid",
                table: "tutor",
                newName: "IX_tutor_Pessoaid");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_Veterinarioid",
                table: "consulta",
                newName: "IX_consulta_Veterinarioid");

            migrationBuilder.RenameIndex(
                name: "IX_Consultas_Animalid",
                table: "consulta",
                newName: "IX_consulta_Animalid");

            migrationBuilder.RenameIndex(
                name: "IX_Animals_Tutorid",
                table: "animal",
                newName: "IX_animal_Tutorid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_veterinario",
                table: "veterinario",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tutor",
                table: "tutor",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_consulta",
                table: "consulta",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_animal",
                table: "animal",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_animal_tutor_Tutorid",
                table: "animal",
                column: "Tutorid",
                principalTable: "tutor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_consulta_animal_Animalid",
                table: "consulta",
                column: "Animalid",
                principalTable: "animal",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_consulta_veterinario_Veterinarioid",
                table: "consulta",
                column: "Veterinarioid",
                principalTable: "veterinario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tutor_pessoa_Pessoaid",
                table: "tutor",
                column: "Pessoaid",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_veterinario_pessoa_Pessoaid",
                table: "veterinario",
                column: "Pessoaid",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_animal_tutor_Tutorid",
                table: "animal");

            migrationBuilder.DropForeignKey(
                name: "FK_consulta_animal_Animalid",
                table: "consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_consulta_veterinario_Veterinarioid",
                table: "consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_tutor_pessoa_Pessoaid",
                table: "tutor");

            migrationBuilder.DropForeignKey(
                name: "FK_veterinario_pessoa_Pessoaid",
                table: "veterinario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_veterinario",
                table: "veterinario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tutor",
                table: "tutor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_consulta",
                table: "consulta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_animal",
                table: "animal");

            migrationBuilder.RenameTable(
                name: "veterinario",
                newName: "Veterinarios");

            migrationBuilder.RenameTable(
                name: "tutor",
                newName: "Tutores");

            migrationBuilder.RenameTable(
                name: "consulta",
                newName: "Consultas");

            migrationBuilder.RenameTable(
                name: "animal",
                newName: "Animals");

            migrationBuilder.RenameIndex(
                name: "IX_veterinario_Pessoaid",
                table: "Veterinarios",
                newName: "IX_Veterinarios_Pessoaid");

            migrationBuilder.RenameIndex(
                name: "IX_tutor_Pessoaid",
                table: "Tutores",
                newName: "IX_Tutores_Pessoaid");

            migrationBuilder.RenameIndex(
                name: "IX_consulta_Veterinarioid",
                table: "Consultas",
                newName: "IX_Consultas_Veterinarioid");

            migrationBuilder.RenameIndex(
                name: "IX_consulta_Animalid",
                table: "Consultas",
                newName: "IX_Consultas_Animalid");

            migrationBuilder.RenameIndex(
                name: "IX_animal_Tutorid",
                table: "Animals",
                newName: "IX_Animals_Tutorid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Veterinarios",
                table: "Veterinarios",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tutores",
                table: "Tutores",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Consultas",
                table: "Consultas",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Animals",
                table: "Animals",
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
    }
}
