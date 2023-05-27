using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistDist.Migrations
{
    /// <inheritdoc />
    public partial class AjusteDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "pis_pasesp",
                table: "veterinario",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ctps_serie",
                table: "veterinario",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ctps_numero",
                table: "veterinario",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ctps_estado",
                table: "veterinario",
                type: "character varying(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "crmv_numero",
                table: "veterinario",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "crmv_estado",
                table: "veterinario",
                type: "character varying(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "diagnostico",
                table: "consulta",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "sexo",
                table: "animal",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "raca",
                table: "animal",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "animal",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "especie",
                table: "animal",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "cor",
                table: "animal",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "alergia",
                table: "animal",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateIndex(
                name: "IX_veterinario_pessoa_id",
                table: "veterinario",
                column: "pessoa_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tutor_pessoa_id",
                table: "tutor",
                column: "pessoa_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_animal_tutor_tutor_id",
                table: "animal",
                column: "tutor_id",
                principalTable: "tutor",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_consulta_animal_animal_id",
                table: "consulta",
                column: "animal_id",
                principalTable: "animal",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_consulta_veterinario_veterinario_id",
                table: "consulta",
                column: "veterinario_id",
                principalTable: "veterinario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tutor_pessoa_pessoa_id",
                table: "tutor",
                column: "pessoa_id",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_veterinario_pessoa_pessoa_id",
                table: "veterinario",
                column: "pessoa_id",
                principalTable: "pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.AlterColumn<string>(
                name: "pis_pasesp",
                table: "veterinario",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "ctps_serie",
                table: "veterinario",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "ctps_numero",
                table: "veterinario",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "ctps_estado",
                table: "veterinario",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "crmv_numero",
                table: "veterinario",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "crmv_estado",
                table: "veterinario",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "diagnostico",
                table: "consulta",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "sexo",
                table: "animal",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "raca",
                table: "animal",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "animal",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "especie",
                table: "animal",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "cor",
                table: "animal",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "alergia",
                table: "animal",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.CreateIndex(
                name: "IX_veterinario_pessoa_id",
                table: "veterinario",
                column: "pessoa_id");

            migrationBuilder.CreateIndex(
                name: "IX_tutor_pessoa_id",
                table: "tutor",
                column: "pessoa_id");

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
    }
}
