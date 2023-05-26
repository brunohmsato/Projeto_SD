using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistDist.Migrations
{
    /// <inheritdoc />
    public partial class NewConfigDB_configFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_veterinario_Pessoaid",
                table: "veterinario");

            migrationBuilder.DropIndex(
                name: "IX_tutor_Pessoaid",
                table: "tutor");

            migrationBuilder.DropIndex(
                name: "IX_consulta_Animalid",
                table: "consulta");

            migrationBuilder.DropIndex(
                name: "IX_consulta_Veterinarioid",
                table: "consulta");

            migrationBuilder.DropIndex(
                name: "IX_animal_Tutorid",
                table: "animal");

            migrationBuilder.DropColumn(
                name: "Pessoaid",
                table: "veterinario");

            migrationBuilder.DropColumn(
                name: "Pessoaid",
                table: "tutor");

            migrationBuilder.DropColumn(
                name: "Animalid",
                table: "consulta");

            migrationBuilder.DropColumn(
                name: "Veterinarioid",
                table: "consulta");

            migrationBuilder.DropColumn(
                name: "Tutorid",
                table: "animal");

            migrationBuilder.CreateIndex(
                name: "IX_veterinario_pessoa_id",
                table: "veterinario",
                column: "pessoa_id");

            migrationBuilder.CreateIndex(
                name: "IX_tutor_pessoa_id",
                table: "tutor",
                column: "pessoa_id");

            migrationBuilder.CreateIndex(
                name: "IX_consulta_animal_id",
                table: "consulta",
                column: "animal_id");

            migrationBuilder.CreateIndex(
                name: "IX_consulta_veterinario_id",
                table: "consulta",
                column: "veterinario_id");

            migrationBuilder.CreateIndex(
                name: "IX_animal_tutor_id",
                table: "animal",
                column: "tutor_id");

            migrationBuilder.AddForeignKey(
                name: "FK_animal_tutor_tutor_id",
                table: "animal",
                column: "tutor_id",
                principalTable: "tutor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_consulta_animal_animal_id",
                table: "consulta",
                column: "animal_id",
                principalTable: "animal",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_consulta_veterinario_veterinario_id",
                table: "consulta",
                column: "veterinario_id",
                principalTable: "veterinario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tutor_pessoa_pessoa_id",
                table: "tutor",
                column: "pessoa_id",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_veterinario_pessoa_pessoa_id",
                table: "veterinario",
                column: "pessoa_id",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_animal_tutor_tutor_id",
                table: "animal");

            migrationBuilder.DropForeignKey(
                name: "FK_consulta_animal_animal_id",
                table: "consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_consulta_veterinario_veterinario_id",
                table: "consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_tutor_pessoa_pessoa_id",
                table: "tutor");

            migrationBuilder.DropForeignKey(
                name: "FK_veterinario_pessoa_pessoa_id",
                table: "veterinario");

            migrationBuilder.DropIndex(
                name: "IX_veterinario_pessoa_id",
                table: "veterinario");

            migrationBuilder.DropIndex(
                name: "IX_tutor_pessoa_id",
                table: "tutor");

            migrationBuilder.DropIndex(
                name: "IX_consulta_animal_id",
                table: "consulta");

            migrationBuilder.DropIndex(
                name: "IX_consulta_veterinario_id",
                table: "consulta");

            migrationBuilder.DropIndex(
                name: "IX_animal_tutor_id",
                table: "animal");

            migrationBuilder.AddColumn<int>(
                name: "Pessoaid",
                table: "veterinario",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pessoaid",
                table: "tutor",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Animalid",
                table: "consulta",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Veterinarioid",
                table: "consulta",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tutorid",
                table: "animal",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_veterinario_Pessoaid",
                table: "veterinario",
                column: "Pessoaid");

            migrationBuilder.CreateIndex(
                name: "IX_tutor_Pessoaid",
                table: "tutor",
                column: "Pessoaid");

            migrationBuilder.CreateIndex(
                name: "IX_consulta_Animalid",
                table: "consulta",
                column: "Animalid");

            migrationBuilder.CreateIndex(
                name: "IX_consulta_Veterinarioid",
                table: "consulta",
                column: "Veterinarioid");

            migrationBuilder.CreateIndex(
                name: "IX_animal_Tutorid",
                table: "animal",
                column: "Tutorid");

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
    }
}
