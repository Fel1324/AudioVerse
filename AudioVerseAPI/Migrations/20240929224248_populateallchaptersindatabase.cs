using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AudioVerseAPI.Migrations
{
    /// <inheritdoc />
    public partial class populateallchaptersindatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Chapter",
                columns: new[] { "Id", "BookId", "ChapterName", "ChapterUrl", "Reader" },
                values: new object[,]
                {
                    { 136, 7, "1", "https://ia800701.us.archive.org/33/items/casavelha_1504_librivox/casavelha_01_assis_128kb.mp3", "Felipe Vale da Silva" },
                    { 137, 7, "2", "https://ia800701.us.archive.org/33/items/casavelha_1504_librivox/casavelha_02_assis_128kb.mp3", "Felipe Vale da Silva" },
                    { 138, 7, "3", "https://ia800701.us.archive.org/33/items/casavelha_1504_librivox/casavelha_03_assis_128kb.mp3", "Felipe Vale da Silva" },
                    { 139, 7, "4", "https://ia800701.us.archive.org/33/items/casavelha_1504_librivox/casavelha_04_assis_128kb.mp3", "Felipe Vale da Silva" },
                    { 140, 7, "5", "https://ia800701.us.archive.org/33/items/casavelha_1504_librivox/casavelha_05_assis_128kb.mp3", "Felipe Vale da Silva" },
                    { 141, 7, "6", "https://ia800701.us.archive.org/33/items/casavelha_1504_librivox/casavelha_06_assis_128kb.mp3", "Felipe Vale da Silva" },
                    { 142, 7, "7", "https://ia800701.us.archive.org/33/items/casavelha_1504_librivox/casavelha_07_assis_128kb.mp3", "Felipe Vale da Silva" },
                    { 143, 7, "8", "https://ia800701.us.archive.org/33/items/casavelha_1504_librivox/casavelha_08_assis_128kb.mp3", "Felipe Vale da Silva" },
                    { 144, 8, "1", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_01_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 145, 8, "2", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_02_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 146, 8, "3", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_03_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 147, 8, "4", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_04_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 148, 8, "5", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_05_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 149, 8, "6", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_06_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 150, 8, "7", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_07_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 151, 8, "8", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_08_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 152, 8, "9", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_09_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 153, 8, "10", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_10_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 154, 8, "11", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_11_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 155, 8, "12", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_12_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 156, 8, "13", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_13_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 157, 8, "14", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_14_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 158, 8, "15", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_15_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 159, 8, "16", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_16_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 160, 8, "17", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_17_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 161, 8, "18", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_18_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 162, 8, "19", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_19_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 163, 8, "20", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_20_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 164, 8, "21", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_21_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 165, 8, "22", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_22_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 166, 8, "23", "https://ia802803.us.archive.org/18/items/cortio_1808_librivox/cortio_23_azevedo_128kb.mp3", "Adriana Sacciotto" },
                    { 167, 9, "1", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_01_alencar.mp3", "Vicente Costa Filho" },
                    { 168, 9, "2", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_02_alencar.mp3", "Vicente Costa Filho" },
                    { 169, 9, "3", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_03_alencar.mp3", "Vicente Costa Filho" },
                    { 170, 9, "4", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_04_alencar.mp3", "Vicente Costa Filho" },
                    { 171, 9, "5", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_05_alencar.mp3", "Vicente Costa Filho" },
                    { 172, 9, "6", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_06_alencar.mp3", "Vicente Costa Filho" },
                    { 173, 9, "7", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_07_alencar.mp3", "Vicente Costa Filho" },
                    { 174, 9, "8", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_08_alencar.mp3", "Vicente Costa Filho" },
                    { 175, 9, "9", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_09_alencar.mp3", "Vicente Costa Filho" },
                    { 176, 9, "10", "https://ia801300.us.archive.org/34/items/cinco_minutos_vcf_librivox/cincominutos_10_alencar.mp3", "Vicente Costa Filho" },
                    { 177, 10, "1", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_01_pompeia.mp3", "Leni" },
                    { 178, 10, "2", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_02_pompeia.mp3", "Leni" },
                    { 179, 10, "3", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_03_pompeia.mp3", "Vicente Costa Filho" },
                    { 180, 10, "4", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_04_pompeia.mp3", "Leni" },
                    { 181, 10, "5", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_05_pompeia.mp3", "Leni" },
                    { 182, 10, "6", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_06_pompeia.mp3", "Leni" },
                    { 183, 10, "7", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_07_pompeia.mp3", "Leni" },
                    { 184, 10, "8", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_08_pompeia.mp3", "Leni" },
                    { 185, 10, "9", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_09_pompeia.mp3", "Wm Lange" },
                    { 186, 10, "10", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_10_pompeia.mp3", "Wm Lange" },
                    { 187, 10, "11", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_11_pompeia.mp3", "Leni" },
                    { 188, 10, "12", "https://ia801604.us.archive.org/35/items/o_ateneu_1012_librivox/oateneu_12_pompeia.mp3", "Leni" },
                    { 189, 11, "1 e 2", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_1_machadodeassis.mp3", "Leni" },
                    { 190, 11, "3 e 4", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_2_machadodeassis.mp3", "Leni" },
                    { 191, 11, "5", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_3_machadodeassis.mp3", "Leni" },
                    { 192, 11, "6", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_4_machadodeassis.mp3", "Leni" },
                    { 193, 11, "7 e 8", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_5_machadodeassis.mp3", "Leni" },
                    { 194, 11, "9 e 10", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_6_machadodeassis.mp3", "Leni" },
                    { 195, 11, "11", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_7_machadodeassis.mp3", "Leni" },
                    { 196, 11, "12", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_8_machadodeassis.mp3", "Leni" },
                    { 197, 11, "13", "https://ia800208.us.archive.org/18/items/o_alienista_0904_librivox/oalienista_9_machadodeassis.mp3", "Leni" },
                    { 198, 12, "1 - A Lição de Violão", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_01_barreto.mp3", "Miramontes" },
                    { 199, 12, "2 - Reformas Radicais", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_02_barreto.mp3", "Miramontes" },
                    { 200, 12, "3 - A notícia do Genelício", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_03_barreto.mp3", "Miramontes" },
                    { 201, 12, "4 - Desastrosas consequências de um requerimento", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_04_barreto.mp3", "Miramontes" },
                    { 202, 12, "5 - O bibelot", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_05_barreto.mp3", "Miramontes" },
                    { 203, 12, "6 - No 'Sossego'", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_06_barreto.mp3", "Miramontes" },
                    { 204, 12, "7 - Espinhos e flores", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_07_barreto.mp3", "Miramontes" },
                    { 205, 12, "8 - Golias", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_08_barreto.mp3", "Miramontes" },
                    { 206, 12, "9 - 'Peço energia, sigo já'", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_09_barreto.mp3", "Miramontes" },
                    { 207, 12, "10 - O trovador", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_10_barreto.mp3", "Miramontes" },
                    { 208, 12, "11 - Patriotas", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_11_barreto.mp3", "Miramontes" },
                    { 209, 12, "12 - Você, Quaresma, é um visionário", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_12_barreto.mp3", "Miramontes" },
                    { 210, 12, "13 - ... e tornaram logo silenciosos", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_13_barreto.mp3", "Miramontes" },
                    { 211, 12, "14 - O Boqueirão", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_14_barreto.mp3", "Miramontes" },
                    { 212, 12, "15 - A afilhada", "https://ia801307.us.archive.org/34/items/triste_fim_policarpo_quaresma_fm_librivox/tristefimdepolicarpoquaresma_15_barreto.mp3", "Miramontes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 212);
        }
    }
}
