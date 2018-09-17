using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsUs.Data.Migrations
{
    public partial class dviro1f : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "adminId",
                table: "Event",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ca189ed-2063-4584-bf1e-e400658c2c5c", "AQAAAAEAACcQAAAAEOFZkMwvCPPV39+s3aQhs22e5aRqIMhhhYm67btXMEsKwZku1CBgvnm4wsa06middA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ea633978-7425-4138-8515-6b9af1f1b992", "AQAAAAEAACcQAAAAEJzQEBhuIAUkoZirLuFxOc3mldVsrbKP75nIC/PwLGyxqw+5ERbUqJX2ZatUwDBc4g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1025a76c-540c-4c5d-99ed-0e48ea2b3d6b", "AQAAAAEAACcQAAAAEGjb3Fide7oFrDTR6UOPEb9aTdcuguoEEVsRXhtBRgbtUuNTjo6x6A28l1w9OLNp3Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "62cab861-3d3b-43ba-811e-23ba2a61ceab", "AQAAAAEAACcQAAAAEIPEHfkUDwuSRoYBG//Rbt78aeDlS4QCYiefRN4EKQP3iOb07Kd5ePAcxahyHjtEww==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2f1faeb-2f79-4927-ad86-24151981530b", "AQAAAAEAACcQAAAAECCwKL9Ys0pz1xFyJHzSCbLTlKYWKsmgc0jLc5drPuQBOAEAud5y2/gGBDpRWLTrZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "185aa650-4c71-4e22-9a73-ddd64ebdf714", "AQAAAAEAACcQAAAAEL1SYPACBvA20CqSl4XWWM7EHksIjh3eloq3ExY71DxhK59QLjljMWMG3mxbAtFdSg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ff1d6391-f478-49d9-a833-7affe83c4e41", "AQAAAAEAACcQAAAAEEVXAyn+0fNJZUWJQwZGfZkFS6xPHRTHAiZtzd+0GXTrDwKhi7K7QSjHrVlwoolIxg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a529f7c7-6ebe-42ed-a10e-82332319b8c5", "AQAAAAEAACcQAAAAENvm+PoDDdcReyOqPzsLkR5E66UZNF0a0rN/mtLLNyYSS4jp0zm+fPnImmNyjtl2mg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ddefaa01-7c70-49aa-93c0-86d8b86d3afd", "AQAAAAEAACcQAAAAEHcxDsRmhqlBnLB8644DOxbNoOhnjfSnzXfd6YS05LhCszxNtWM3s9eGYAiMgAsKcQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1dd3c2cf-7ecb-4160-8b8d-46dbe15265f9", "AQAAAAEAACcQAAAAEL2MQsSHpGwccd73/JfHhVvEL/2dKL86n7AsQB/9j9JzDplVQdz6fhpYfCH6xObTFQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3cf7ac53-4bd5-4851-9ea6-a08aa0d88108", "AQAAAAEAACcQAAAAEBu8GP1OmTvc2OpQdwhAmlupeHUlAIO2e2DzwOArRUzwuxFpSWBupMTGAks4am1G9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69edbc49-a4ec-4cef-9278-b628fc37adec", "AQAAAAEAACcQAAAAEIzQQgWYWl3vW7x2RLvEZRT/h5Nx6F7Db8llcp4hURzR5k+XD1cChPc7H7udmy9k/g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86c8be7a-8e23-4389-99e6-4b4a0a846c32", "AQAAAAEAACcQAAAAEEbR+ZPK/lFyndqaLHjbSO2+90CHXrWqZVhf2QefKfo38/JS9V2EAketn5KJYDzpdw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5987dfa9-dece-4e90-b70c-fa982f5a2882", "AQAAAAEAACcQAAAAEEMi8EeAR+dkjZDaU/15YUsLZWhTtEFxS9OxUrPuEtrXLP1GHZVOcNdlniRttp6cnA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c27565df-f241-43e8-9bf8-106e83e39b8e", "AQAAAAEAACcQAAAAEOmfwhFTxMNE8OiLZOEhHfPiB9W/se36anJQtMvV61/z10qrvaj+0sr9xV/ku/9P1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0930feb4-a16d-4e34-9194-70c17547f0a9", "AQAAAAEAACcQAAAAEAweUlG2Dmy6GQ2c3qK+2UgA3Py37s4N4ttIxpGiDlRzHCyGIQiRfumArlVAD0N4yw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2492f041-f2c6-4ca8-8cc0-949bf71a5083", "AQAAAAEAACcQAAAAEJDjr3Rn+HkOo2ytRADP9qYIgeM/t+5P/I3y5sIqFjKIQFlQaGMc+uw3iaTqR3vZbQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aa735f41-419d-410a-a252-e0ba651e5a25", "AQAAAAEAACcQAAAAEJXEZCS8OpxWUk9zFOAvLI7HyKWnUeYwGaG+uGvhEH3L8ThS5e/Patw9RLIO9ryfsQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b2930b20-045f-46ee-9476-d871ae107570", "AQAAAAEAACcQAAAAEDrwJEstvDPZFYLGyzgcE9QTZVKr+/lmsk+eqlHNBM2G+1lihDr4fi/49KWhJvGHAA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd5f051a-08f0-44ab-bf33-f9963c0f2798", "AQAAAAEAACcQAAAAEO5+H/9dVSRuQlYvjkam18Dce57nuwEYasgwdB84MwLRSuxh7dBE1lawMaPAUYcTAA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2de551c9-868a-4c33-bce5-5c4172237d14", "AQAAAAEAACcQAAAAEGpEscJOD7uodAr5o64Py1WiUGUQfvKcz/gstEDrNZHFhlcY01Rwg0lr7LnjcA9/Mw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "adminId",
                table: "Event",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin_ID_123456789",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f644830b-8412-4c75-a705-1956891e3c8c", "AQAAAAEAACcQAAAAEIm16AqqiKLKIMHZ2JYkPJy9z5wvcQ7wKeFbZL6Db1xFPwsmOXeorMYs6QkoQUzj9Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7000",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c2aa75a1-984e-409a-a6c9-2d234fc5f79e", "AQAAAAEAACcQAAAAELWhel3CIUycIZ1fycGWmDjn14Y+5d/UpWzAi+PLlFG9RhOyRp9XWI6h/nm5JtUrFQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7037b2a0-bd10-4a84-8dc4-09d64d5b10f8", "AQAAAAEAACcQAAAAEAPuCYWgDbjYZlTPADIjjSpwjkNmt03piSW/xfmLPWKk47VzWwtvl8KzpN1Tnl9tRA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "016ebcba-66fe-4b88-ae16-d99048df10b0", "AQAAAAEAACcQAAAAEN/V6UahYFD2gdUVMIz/0M5xosrGQNJPgC1dG1KyANAfRekzbtCpGRH+YxHWIm5uCg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70f6a895-154d-442a-b878-434a24e643eb", "AQAAAAEAACcQAAAAEKGnbZK4USXZzVfNOoK5rw7Rtwv/t+R1qZ9BqND42rE7VFgzLns9DJeZ+kjLyjynVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7004",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce4cd2af-c21c-44ef-8b5d-758c1165d3d8", "AQAAAAEAACcQAAAAEFEaEgcwjH4OUjj7wvTcHIV7HoNeo6IZkqMZFgUCLpu39+ZW7LWQJqIbeCNXLlX98A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7005",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d761e82d-5147-4f6a-950a-13ed3374416d", "AQAAAAEAACcQAAAAEGsgQvRnzlHaOP6kQA4KDBjfiTtyJy8B76NU5CJXniYsWcvX8g+fRHxB9RWShbjapQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7006",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3837ebc4-d407-42dc-ba5b-543bc587e593", "AQAAAAEAACcQAAAAEI8Jo0PeaQ26efTvKvTRVzDw4TVkUz42fpHCRTroCzMYluv/gdtNMeLebpWQRg1EiA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7007",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c631a6d2-b423-4133-9202-556cabda1993", "AQAAAAEAACcQAAAAEN7v5YRjiaI/i3xVDkPhbHESWt0kctr2nBLwCcvZS8KzLOvzLkwdNBPRVZOx8ad4wQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7008",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "62e5a136-dccf-42c5-9435-db981b8b1a3b", "AQAAAAEAACcQAAAAEMNh2EOr7JZPG5d4IMKcLq8ZF5lZQ4EueV8KEwlZHGZcDAQO/MyIIxSLKbKs4eeNHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7009",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "406cf7a6-35f9-4b65-bcc4-53192e9b3127", "AQAAAAEAACcQAAAAEO5tkQCK+LXViWARVnLPdpnd/PS8qhCBrc4S/1gqBzuk0CxXyfU12yN1H2899KzAhw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7010",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca56433f-db65-4df8-8dbe-eef44fe96fb3", "AQAAAAEAACcQAAAAELAdgPdyAMp6p7qrM3gmh40bW3Z0rd+OFLkS7Bnk6kMSkgdVAGMynGKuIT6hA5KcYA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d5e146c-82d4-443a-9632-1a5e8f091126", "AQAAAAEAACcQAAAAEHUB8IAM5+DKDD1fye+towLB3uGZ0rTTjHldyqCK63xFIBBARerHGWdgrC6GcN9erw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7012",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ac2af8c4-82c3-4461-a052-f344872d0bd6", "AQAAAAEAACcQAAAAEA8uNfaCJhfbalufa8XnSrZNiOfypuOj0bLkU/lGqZtRdknt6YAjox72Ngmz2mB77w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7013",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5801d9c0-01d1-4fba-afc2-e7f55b4c7e0e", "AQAAAAEAACcQAAAAEAEQNzxoAJzeOZQG/jzlPpWi284wxn+cSAXJGFdin7vTXvyvaJUrYFUU4zyJ30ODEA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7014",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8bebdcdd-821b-4c86-bfd9-e3521dce62bf", "AQAAAAEAACcQAAAAELgDGJykfJ2Vf1oyCenVbbGjeDc9wEyygA49JeSLRrhmKfu6nIgaOUw2BUyxW77x2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a0490b2-35b4-4844-a454-816caeb0dab0", "AQAAAAEAACcQAAAAEI5aKIgClv5sD7g0ivkjYXrLM3ELaOj9MuNT7nRGk+B1cRgyzpgThLCk+gWKKkTTkw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7016",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a5f88e2-c31f-4af4-87d3-53321f40f5d0", "AQAAAAEAACcQAAAAELJA4fr+xaqgRHBcAKamev1Mu4v4tU0lQ4VmuBs0vDcfCZFCqBSgCEuM860wbGCa1g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7017",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a364351e-e071-4412-ba2c-e76ea6bf6d68", "AQAAAAEAACcQAAAAEFnkFk3Khcmk/F9UP27yaoxyV/BTKTCmJpyO6Va+mtJ8ByB0G5xnkHlyQpRik6lHfQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7018",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3672d2bb-9768-496b-afea-1e181834fb34", "AQAAAAEAACcQAAAAEGFCzAMpFvI05/ur4TTMbBQbO/b/KVjMxS+zITbsMTQ58cLivJ98+xv639hHSNEOxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Eu_7019",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fd65b970-cf00-4b9b-880d-b559cb7b1de1", "AQAAAAEAACcQAAAAEICCQGrSOK3tomZZPhC57fvQXdUDH/6V2a5gH+Mk9/ujqshpARk5V47uJulFl0P7bA==" });
        }
    }
}
