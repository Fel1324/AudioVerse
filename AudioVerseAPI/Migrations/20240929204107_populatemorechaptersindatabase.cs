using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AudioVerseAPI.Migrations
{
    /// <inheritdoc />
    public partial class populatemorechaptersindatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 1,
                column: "ChapterName",
                value: "1 a 5");

            migrationBuilder.InsertData(
                table: "Chapter",
                columns: new[] { "Id", "BookId", "ChapterName", "ChapterUrl", "Reader" },
                values: new object[,]
                {
                    { 2, 1, "5 a 10", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_02_assis_128kb.mp3", "Rachel Moraes" },
                    { 3, 1, "11 a 15", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_03_assis_128kb.mp3", "Mayah" },
                    { 4, 1, "16 a 20", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_04_assis_128kb.mp3", "Rachel Moraes" },
                    { 5, 1, "21 a 25", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_05_assis_128kb.mp3", "Dey Andriotti" },
                    { 6, 1, "26 a 30", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_06_assis_128kb.mp3", "Rachel Moraes" },
                    { 7, 1, "31 a 35", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_07_assis_128kb.mp3", "Mayah" },
                    { 8, 1, "36 a 40", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_08_assis_128kb.mp3", "Rachel Moraes" },
                    { 9, 1, "41 a 45", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_09_assis_128kb.mp3", "Jane Nogueira" },
                    { 10, 1, "46 a 50", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_10_assis_128kb.mp3", "Rachel Moraes" },
                    { 11, 1, "51 a 55", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_11_assis_128kb.mp3", "MarinaFikota" },
                    { 12, 1, "56 a 60", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_12_assis_128kb.mp3", "Mayah" },
                    { 13, 1, "61 a 65", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_13_assis_128kb.mp3", "Thiago" },
                    { 14, 1, "66 a 70", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_14_assis_128kb.mp3", "Pier" },
                    { 15, 1, "71 a 75", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_15_assis_128kb.mp3", "Rachel Moraes" },
                    { 16, 1, "76 a 80", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_16_assis_128kb.mp3", "gtavares97" },
                    { 17, 1, "81 a 85", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_17_assis_128kb.mp3", "Maria de Fátima da Silva" },
                    { 18, 1, "86 a 90", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_18_assis_128kb.mp3", "Maria de Fátima da Silva" },
                    { 19, 1, "91 a 95", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_19_assis_128kb.mp3", "Maria de Fátima da Silva" },
                    { 20, 1, "96 a 100", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_20_assis_128kb.mp3", "Dey Andriotti" },
                    { 21, 1, "101 a 105", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_21_assis_128kb.mp3", "Pier" },
                    { 22, 1, "106 a 110", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_22_assis_128kb.mp3", "Rachel Moraes" },
                    { 23, 1, "111 a 115", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_23_assis_128kb.mp3", "jessicapmaximo" },
                    { 24, 1, "116 a 120", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_24_assis_128kb.mp3", "gtavares97" },
                    { 25, 1, "121 a 125", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_25_assis_128kb.mp3", "Rachel Moraes" },
                    { 26, 1, "126 a 130", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_26_assis_128kb.mp3", "Isa" },
                    { 27, 1, "131 a 135", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_27_assis_128kb.mp3", "MarinaFikota" },
                    { 28, 1, "136 a 140", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_28_assis_128kb.mp3", "MarinaFikota" },
                    { 29, 1, "141 a 145", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_29_assis_128kb.mp3", "Rachel Moraes" },
                    { 30, 1, "146 a 148", "https://ia601802.us.archive.org/7/items/dom_casmurro_2102_librivox/domcasmurro_30_assis_128kb.mp3", "Lucas Oliveira" },
                    { 31, 2, "1 a 5", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_01_dealencar_128kb.mp3", "RogerioM" },
                    { 32, 2, "6 a 10", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_02_dealencar_128kb.mp3", "RogerioM" },
                    { 33, 2, "11 a 14", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_03_dealencar_128kb.mp3", "RogerioM" },
                    { 34, 2, "15 a 19", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_04_dealencar_128kb.mp3", "RogerioM" },
                    { 35, 2, "20 a 24", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_05_dealencar_128kb.mp3", "RogerioM" },
                    { 36, 2, "25 a 29", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_06_dealencar_128kb.mp3", "RogerioM" },
                    { 37, 2, "30 a 33", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_07_dealencar_128kb.mp3", "RogerioM" },
                    { 38, 2, "Notas - parte 1", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_08_dealencar_128kb.mp3", "RogerioM" },
                    { 39, 2, "Notas - parte 2", "https://ia800808.us.archive.org/27/items/iracema_1708_librivox/iracema_09_dealencar_128kb.mp3", "RogerioM" },
                    { 40, 3, "Parte 1, 1", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_01_alencar.mp3", "Leni" },
                    { 41, 3, "Parte 1, 2", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_02_alencar.mp3", "Leni" },
                    { 42, 3, "Parte 1, 3", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_03_alencar.mp3", "Leni" },
                    { 43, 3, "Parte 1, 4", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_04_alencar.mp3", "Leni" },
                    { 44, 3, "Parte 1, 5", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_05_alencar.mp3", "Leni" },
                    { 45, 3, "Parte 1, 6", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_06_alencar.mp3", "Leni" },
                    { 46, 3, "Parte 1, 7", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_07_alencar.mp3", "Leni" },
                    { 47, 3, "Parte 1, 8", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_08_alencar.mp3", "Leni" },
                    { 48, 3, "Parte 1, 9", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_09_alencar.mp3", "Leni" },
                    { 49, 3, "Parte 1, 10", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_10_alencar.mp3", "Leni" },
                    { 50, 3, "Parte 1, 11", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_11_alencar.mp3", "Leni" },
                    { 51, 3, "Parte 1, 12", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_12_alencar.mp3", "Leni" },
                    { 52, 3, "Parte 1, 13", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_13_alencar.mp3", "Leni" },
                    { 53, 3, "Parte 2, 1", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_14_alencar.mp3", "Leni" },
                    { 54, 3, "Parte 2, 2", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_15_alencar.mp3", "Leni" },
                    { 55, 3, "Parte 2, 3", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_16_alencar.mp3", "Leni" },
                    { 56, 3, "Parte 2, 4", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_17_alencar.mp3", "Leni" },
                    { 57, 3, "Parte 2, 5", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_18_alencar.mp3", "Leni" },
                    { 58, 3, "Parte 2, 6", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_19_alencar.mp3", "Leni" },
                    { 59, 3, "Parte 2, 7", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_20_alencar.mp3", "Leni" },
                    { 60, 3, "Parte 2, 8", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_21_alencar.mp3", "Leni" },
                    { 61, 3, "Parte 2, 9", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_22_alencar.mp3", "Leni" },
                    { 62, 3, "Parte 3, 1", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_23_alencar.mp3", "Leni" },
                    { 63, 3, "Parte 3, 2", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_24_alencar.mp3", "Leni" },
                    { 64, 3, "Parte 3, 3", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_25_alencar.mp3", "Leni" },
                    { 65, 3, "Parte 3, 4", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_26_alencar.mp3", "Leni" },
                    { 66, 3, "Parte 3, 5", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_27_alencar.mp3", "Leni" },
                    { 67, 3, "Parte 3, 6", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_28_alencar.mp3", "Leni" },
                    { 68, 3, "Parte 3, 7", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_29_alencar.mp3", "Leni" },
                    { 69, 3, "Parte 3, 8", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_30_alencar.mp3", "Leni" },
                    { 70, 3, "Parte 3, 9", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_31_alencar.mp3", "Leni" },
                    { 71, 3, "Parte 3, 10", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_32_alencar.mp3", "Leni" },
                    { 72, 3, "Parte 4, 1", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_33_alencar.mp3", "Leni" },
                    { 73, 3, "Parte 4, 2", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_34_alencar.mp3", "Leni" },
                    { 74, 3, "Parte 4, 3", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_35_alencar.mp3", "Leni" },
                    { 75, 3, "Parte 4, 4", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_36_alencar.mp3", "Leni" },
                    { 76, 3, "Parte 4, 5", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_37_alencar.mp3", "Leni" },
                    { 77, 3, "Parte 4, 6", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_38_alencar.mp3", "Leni" },
                    { 78, 3, "Parte 4, 7", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_39_alencar.mp3", "Leni" },
                    { 79, 3, "Parte 4, 8", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_40_alencar.mp3", "Leni" },
                    { 80, 3, "Parte 4, 9", "https://ia801306.us.archive.org/12/items/senhora_0910_librivox/senhora_41_alencar.mp3", "Leni" },
                    { 81, 4, "1 a 5", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_01_assis_128kb.mp3", "Leni" },
                    { 82, 4, "6 a 10", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_02_assis_128kb.mp3", "Leni" },
                    { 83, 4, "11 a 15", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_03_assis_128kb.mp3", "Leni" },
                    { 84, 4, "15 a 20", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_04_assis_128kb.mp3", "Leni" },
                    { 85, 4, "21 a 25", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_05_assis_128kb.mp3", "Leni" },
                    { 86, 4, "26 a 30", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_06_assis_128kb.mp3", "Leni" },
                    { 87, 4, "31 a 35", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_07_assis_128kb.mp3", "Leni" },
                    { 88, 4, "36 a 40", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_08_assis_128kb.mp3", "Leni" },
                    { 89, 4, "41 a 45", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_09_assis_128kb.mp3", "Leni" },
                    { 90, 4, "46 a 50", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_10_assis_128kb.mp3", "Leni" },
                    { 91, 4, "51 a 55", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_11_assis_128kb.mp3", "Leni" },
                    { 92, 4, "56 a 60", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_12_assis_128kb.mp3", "Leni" },
                    { 93, 4, "61 a 65", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_13_assis_128kb.mp3", "Leni" },
                    { 94, 4, "66 a 70", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_14_assis_128kb.mp3", "Leni" },
                    { 95, 4, "71 a 75", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_15_assis_128kb.mp3", "Leni" },
                    { 96, 4, "76 a 80", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_16_assis_128kb.mp3", "Leni" },
                    { 97, 4, "81 a 85", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_17_assis_128kb.mp3", "Leni" },
                    { 98, 4, "86 a 90", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_18_assis_128kb.mp3", "Leni" },
                    { 99, 4, "91 a 95", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_19_assis_128kb.mp3", "Leni" },
                    { 100, 4, "96 a 100", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_20_assis_128kb.mp3", "Leni" },
                    { 101, 4, "101 a 105", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_21_assis_128kb.mp3", "Leni" },
                    { 102, 4, "106 a 110", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_22_assis_128kb.mp3", "Leni" },
                    { 103, 4, "111 a 115", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_23_assis_128kb.mp3", "Leni" },
                    { 104, 4, "116 a 120", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_24_assis_128kb.mp3", "Leni" },
                    { 105, 4, "121 a 125", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_25_assis_128kb.mp3", "Leni" },
                    { 106, 4, "126 a 130", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_26_assis_128kb.mp3", "Leni" },
                    { 107, 4, "131 a 135", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_27_assis_128kb.mp3", "Leni" },
                    { 108, 4, "136 a 140", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_28_assis_128kb.mp3", "Leni" },
                    { 109, 4, "141 a 145", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_29_assis_128kb.mp3", "Leni" },
                    { 110, 4, "146 a 150", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_30_assis_128kb.mp3", "Leni" },
                    { 111, 4, "151 a 155", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_31_assis_128kb.mp3", "Leni" },
                    { 112, 4, "156 a 160", "https://ia802802.us.archive.org/11/items/memoriaspostumas_debrascubas_1912_librivox/memoriaspostumas_32_assis_128kb.mp3", "Leni" },
                    { 113, 5, ": A Cartomante", "https://ia804609.us.archive.org/1/items/contos_brasileiros_0807_librivox/contos_brasileiros_11.mp3", "Joao Paulo" },
                    { 114, 6, "0", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_00_alencar_128kb.mp3", "Leni" },
                    { 115, 6, "1", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_01_alencar_128kb.mp3", "Leni" },
                    { 116, 6, "2", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_02_alencar_128kb.mp3", "Leni" },
                    { 117, 6, "3", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_03_alencar_128kb.mp3", "Leni" },
                    { 118, 6, "4", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_04_alencar_128kb.mp3", "Leni" },
                    { 119, 6, "5", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_05_alencar_128kb.mp3", "Leni" },
                    { 120, 6, "6", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_06_alencar_128kb.mp3", "Leni" },
                    { 121, 6, "7", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_07_alencar_128kb.mp3", "Leni" },
                    { 122, 6, "8", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_08_alencar_128kb.mp3", "Leni" },
                    { 123, 6, "9", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_09_alencar_128kb.mp3", "Leni" },
                    { 124, 6, "10", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_10_alencar_128kb.mp3", "Leni" },
                    { 125, 6, "11", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_11_alencar_128kb.mp3", "Leni" },
                    { 126, 6, "12", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_12_alencar_128kb.mp3", "Leni" },
                    { 127, 6, "13", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_13_alencar_128kb.mp3", "Leni" },
                    { 128, 6, "14", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_14_alencar_128kb.mp3", "Leni" },
                    { 129, 6, "15", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_15_alencar_128kb.mp3", "Leni" },
                    { 130, 6, "16", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_16_alencar_128kb.mp3", "Leni" },
                    { 131, 6, "17", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_17_alencar_128kb.mp3", "Leni" },
                    { 132, 6, "18", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_18_alencar_128kb.mp3", "Leni" },
                    { 133, 6, "19", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_19_alencar_128kb.mp3", "Leni" },
                    { 134, 6, "20", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_20_alencar_128kb.mp3", "Leni" },
                    { 135, 6, "21", "https://dn720308.ca.archive.org/0/items/luciola_2206_librivox/luciola_21_alencar_128kb.mp3", "Leni" }
                });

            migrationBuilder.InsertData(
                table: "GenreBook",
                columns: new[] { "BookId", "GenreId" },
                values: new object[] { 4, 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "GenreBook",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "Chapter",
                keyColumn: "Id",
                keyValue: 1,
                column: "ChapterName",
                value: "I a V");
        }
    }
}
