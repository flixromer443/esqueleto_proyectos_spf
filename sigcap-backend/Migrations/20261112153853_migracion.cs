using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace sigcapbackend.Migrations
{
    /// <inheritdoc />
    public partial class migracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Combustibles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combustibles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados_afectacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Estado = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_afectacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados_alerta_recuento_fisico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Estado = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_alerta_recuento_fisico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados_bienes_de_uso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Estado = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_bienes_de_uso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados_dispositivos_telepase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Estado = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_dispositivos_telepase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados_operativos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Estado = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_operativos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados_sesion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Estado = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_sesion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados_tarjetas_combustible",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Estado = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_tarjetas_combustible", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estados_usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Estado = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seguros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Valor_cuota = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Situaciones_dominiales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Situacion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Situaciones_dominiales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Talleres_mecanicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cod_postal = table.Column<string>(type: "text", nullable: false),
                    Calle = table.Column<string>(type: "text", nullable: false),
                    numero = table.Column<int>(type: "integer", nullable: false),
                    Localidad = table.Column<string>(type: "text", nullable: false),
                    Provincia = table.Column<string>(type: "text", nullable: false),
                    Entrecalle_1 = table.Column<string>(type: "text", nullable: false),
                    Entrecalle_2 = table.Column<string>(type: "text", nullable: false),
                    Denominacion = table.Column<string>(type: "text", nullable: false),
                    Cuit = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talleres_mecanicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_adquisicion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tipo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_adquisicion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_baja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tipo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_baja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_documentos_digitales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tipo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_documentos_digitales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_estado_historicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tipo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_estado_historicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tipo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_vehiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Kg_chatarra = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vidas_utiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Anios_vida_util = table.Column<double>(type: "double precision", nullable: false),
                    Porc_amortizacion = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vidas_utiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fichas_tecnicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Estado_operativoId = table.Column<int>(type: "integer", nullable: false),
                    Estado_afectacionId = table.Column<int>(type: "integer", nullable: false),
                    CombustibleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fichas_tecnicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fichas_tecnicas_Combustibles_CombustibleId",
                        column: x => x.CombustibleId,
                        principalTable: "Combustibles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fichas_tecnicas_Estados_afectacion_Estado_afectacionId",
                        column: x => x.Estado_afectacionId,
                        principalTable: "Estados_afectacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fichas_tecnicas_Estados_operativos_Estado_operativoId",
                        column: x => x.Estado_operativoId,
                        principalTable: "Estados_operativos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    MarcaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modelos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Contrasenia = table.Column<string>(type: "text", nullable: false),
                    perfilId = table.Column<int>(type: "integer", nullable: false),
                    estado_sesionId = table.Column<int>(type: "integer", nullable: false),
                    estado_usuarioId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Estados_sesion_estado_sesionId",
                        column: x => x.estado_sesionId,
                        principalTable: "Estados_sesion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Estados_usuarios_estado_usuarioId",
                        column: x => x.estado_usuarioId,
                        principalTable: "Estados_usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Perfiles_perfilId",
                        column: x => x.perfilId,
                        principalTable: "Perfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rel_perfiles_roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    perfilId = table.Column<int>(type: "integer", nullable: false),
                    rolId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rel_perfiles_roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rel_perfiles_roles_Perfiles_perfilId",
                        column: x => x.perfilId,
                        principalTable: "Perfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rel_perfiles_roles_Roles_rolId",
                        column: x => x.rolId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inmuebles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Latitud = table.Column<string>(type: "text", nullable: false),
                    Longitud = table.Column<string>(type: "text", nullable: false),
                    Calle = table.Column<string>(type: "text", nullable: false),
                    Entre_calle_1 = table.Column<string>(type: "text", nullable: false),
                    Entre_calle_2 = table.Column<string>(type: "text", nullable: false),
                    Provincia = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<int>(type: "integer", nullable: false),
                    Cod_postal = table.Column<string>(type: "text", nullable: false),
                    situacion_DominialId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inmuebles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inmuebles_Situaciones_dominiales_situacion_DominialId",
                        column: x => x.situacion_DominialId,
                        principalTable: "Situaciones_dominiales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subtipos_adquisicion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    Tipo_AdquisicionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subtipos_adquisicion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subtipos_adquisicion_Tipos_adquisicion_Tipo_AdquisicionId",
                        column: x => x.Tipo_AdquisicionId,
                        principalTable: "Tipos_adquisicion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alertas_recuento_fisico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UnidadId = table.Column<int>(type: "integer", nullable: false),
                    F_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    F_recuento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Estado_alerta_recuento_fisicoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alertas_recuento_fisico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alertas_recuento_fisico_Estados_alerta_recuento_fisico_Esta~",
                        column: x => x.Estado_alerta_recuento_fisicoId,
                        principalTable: "Estados_alerta_recuento_fisico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alertas_recuento_fisico_Unidades_UnidadId",
                        column: x => x.UnidadId,
                        principalTable: "Unidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Codigos_presupuestarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<int>(type: "integer", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Vida_util_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Codigos_presupuestarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Codigos_presupuestarios_Vidas_utiles_Vida_util_id",
                        column: x => x.Vida_util_id,
                        principalTable: "Vidas_utiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Dispositivos_telepase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    F_emision = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    F_baja = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    Ficha_tecnicaId = table.Column<int>(type: "integer", nullable: false),
                    Estado_dispositivo_telepaseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dispositivos_telepase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dispositivos_telepase_Estados_dispositivos_telepase_Estado_~",
                        column: x => x.Estado_dispositivo_telepaseId,
                        principalTable: "Estados_dispositivos_telepase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dispositivos_telepase_Fichas_tecnicas_Ficha_tecnicaId",
                        column: x => x.Ficha_tecnicaId,
                        principalTable: "Fichas_tecnicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mantenimientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    F_ingreso = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    F_alta = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Kilometraje = table.Column<int>(type: "integer", nullable: false),
                    Observacion = table.Column<string>(type: "text", nullable: false),
                    Ficha_tecnicaId = table.Column<int>(type: "integer", nullable: false),
                    Taller_mecanicoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mantenimientos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mantenimientos_Fichas_tecnicas_Ficha_tecnicaId",
                        column: x => x.Ficha_tecnicaId,
                        principalTable: "Fichas_tecnicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mantenimientos_Talleres_mecanicos_Taller_mecanicoId",
                        column: x => x.Taller_mecanicoId,
                        principalTable: "Talleres_mecanicos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tarjetas_combustible",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    F_emision = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    F_vencimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Titular = table.Column<string>(type: "text", nullable: false),
                    CVV = table.Column<int>(type: "integer", nullable: false),
                    Bco_emisor = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    Estado_tarjeta_combustibleId = table.Column<int>(type: "integer", nullable: false),
                    Ficha_tecnicaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjetas_combustible", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarjetas_combustible_Estados_tarjetas_combustible_Estado_ta~",
                        column: x => x.Estado_tarjeta_combustibleId,
                        principalTable: "Estados_tarjetas_combustible",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tarjetas_combustible_Fichas_tecnicas_Ficha_tecnicaId",
                        column: x => x.Ficha_tecnicaId,
                        principalTable: "Fichas_tecnicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Dominio = table.Column<string>(type: "text", nullable: false),
                    kilometraje = table.Column<double>(type: "double precision", nullable: false),
                    nro_motor = table.Column<string>(type: "text", nullable: false),
                    nro_chasis = table.Column<string>(type: "text", nullable: false),
                    anio = table.Column<int>(type: "integer", nullable: false),
                    Ficha_tecnica_id = table.Column<int>(type: "integer", nullable: true),
                    MarcaId = table.Column<int>(type: "integer", nullable: false),
                    ModeloId = table.Column<int>(type: "integer", nullable: false),
                    seguroId = table.Column<int>(type: "integer", nullable: false),
                    Tipo_vehiculoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Fichas_tecnicas_Ficha_tecnica_id",
                        column: x => x.Ficha_tecnica_id,
                        principalTable: "Fichas_tecnicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Modelos_ModeloId",
                        column: x => x.ModeloId,
                        principalTable: "Modelos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Seguros_seguroId",
                        column: x => x.seguroId,
                        principalTable: "Seguros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Tipos_vehiculos_Tipo_vehiculoId",
                        column: x => x.Tipo_vehiculoId,
                        principalTable: "Tipos_vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Historicos_estado_afectacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    usuarioId = table.Column<int>(type: "integer", nullable: false),
                    ficha_tecnicaId = table.Column<int>(type: "integer", nullable: false),
                    EstadoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos_estado_afectacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_afectacion_Estados_afectacion_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados_afectacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_afectacion_Fichas_tecnicas_ficha_tecnicaId",
                        column: x => x.ficha_tecnicaId,
                        principalTable: "Fichas_tecnicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_afectacion_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Historicos_estado_operativo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    usuarioId = table.Column<int>(type: "integer", nullable: false),
                    ficha_tecnicaId = table.Column<int>(type: "integer", nullable: false),
                    EstadoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos_estado_operativo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_operativo_Estados_operativos_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados_operativos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_operativo_Fichas_tecnicas_ficha_tecnicaId",
                        column: x => x.ficha_tecnicaId,
                        principalTable: "Fichas_tecnicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_operativo_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Historicos_estado_sesion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    usuarioId = table.Column<int>(type: "integer", nullable: false),
                    EstadoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos_estado_sesion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_sesion_Estados_sesion_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados_sesion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_sesion_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Historicos_estado_usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    usuarioId = table.Column<int>(type: "integer", nullable: false),
                    EstadoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos_estado_usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_usuario_Estados_usuarios_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados_usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_usuario_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documentos_digitales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Uri_archivo = table.Column<string>(type: "text", nullable: false),
                    TipoId = table.Column<int>(type: "integer", nullable: false),
                    InmuebleId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos_digitales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documentos_digitales_Inmuebles_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Documentos_digitales_Tipos_documentos_digitales_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos_documentos_digitales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Historicos_situacion_dominial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    usuarioId = table.Column<int>(type: "integer", nullable: false),
                    inmuebleId = table.Column<int>(type: "integer", nullable: false),
                    SituacionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos_situacion_dominial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_situacion_dominial_Inmuebles_inmuebleId",
                        column: x => x.inmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_situacion_dominial_Situaciones_dominiales_Situac~",
                        column: x => x.SituacionId,
                        principalTable: "Situaciones_dominiales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_situacion_dominial_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Observaciones_inmueble",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Observacion = table.Column<string>(type: "text", nullable: false),
                    InmuebleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observaciones_inmueble", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Observaciones_inmueble_Inmuebles_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Historicos_estado_alerta_recuento_fisico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    usuarioId = table.Column<int>(type: "integer", nullable: false),
                    AlertaId = table.Column<int>(type: "integer", nullable: false),
                    EstadoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos_estado_alerta_recuento_fisico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_alerta_recuento_fisico_Alertas_recuento_f~",
                        column: x => x.AlertaId,
                        principalTable: "Alertas_recuento_fisico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_alerta_recuento_fisico_Estados_alerta_rec~",
                        column: x => x.EstadoId,
                        principalTable: "Estados_alerta_recuento_fisico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_alerta_recuento_fisico_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cod_clase = table.Column<int>(type: "integer", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Codigo_presupuestarioId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clases_Codigos_presupuestarios_Codigo_presupuestarioId",
                        column: x => x.Codigo_presupuestarioId,
                        principalTable: "Codigos_presupuestarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Historicos_estado_dispositivo_telepase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    usuarioId = table.Column<int>(type: "integer", nullable: false),
                    dispositivo_telepaseId = table.Column<int>(type: "integer", nullable: false),
                    EstadoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos_estado_dispositivo_telepase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_dispositivo_telepase_Dispositivos_telepas~",
                        column: x => x.dispositivo_telepaseId,
                        principalTable: "Dispositivos_telepase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_dispositivo_telepase_Estados_dispositivos~",
                        column: x => x.EstadoId,
                        principalTable: "Estados_dispositivos_telepase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_dispositivo_telepase_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agentes_asociados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Credencial = table.Column<int>(type: "integer", nullable: false),
                    Tarjeta_combustibleId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agentes_asociados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agentes_asociados_Tarjetas_combustible_Tarjeta_combustibleId",
                        column: x => x.Tarjeta_combustibleId,
                        principalTable: "Tarjetas_combustible",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Historicos_estado_tarjeta_combustible",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    usuarioId = table.Column<int>(type: "integer", nullable: false),
                    tarjeta_combustibleId = table.Column<int>(type: "integer", nullable: false),
                    EstadoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos_estado_tarjeta_combustible", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_tarjeta_combustible_Estados_tarjetas_comb~",
                        column: x => x.EstadoId,
                        principalTable: "Estados_tarjetas_combustible",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_tarjeta_combustible_Tarjetas_combustible_~",
                        column: x => x.tarjeta_combustibleId,
                        principalTable: "Tarjetas_combustible",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_tarjeta_combustible_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Muebles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Vehiculo_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muebles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Muebles_Vehiculos_Vehiculo_id",
                        column: x => x.Vehiculo_id,
                        principalTable: "Vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Subclases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cod_subclase = table.Column<int>(type: "integer", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    claseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subclases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subclases_Clases_claseId",
                        column: x => x.claseId,
                        principalTable: "Clases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Codigos_qr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    F_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Mueble_id = table.Column<int>(type: "integer", nullable: true),
                    Inmueble_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Codigos_qr", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Codigos_qr_Inmuebles_Inmueble_id",
                        column: x => x.Inmueble_id,
                        principalTable: "Inmuebles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Codigos_qr_Muebles_Mueble_id",
                        column: x => x.Mueble_id,
                        principalTable: "Muebles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Observaciones_muebles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Observacion = table.Column<string>(type: "text", nullable: false),
                    MuebleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observaciones_muebles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Observaciones_muebles_Muebles_MuebleId",
                        column: x => x.MuebleId,
                        principalTable: "Muebles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Partidas_presupuestarias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    unidadId = table.Column<int>(type: "integer", nullable: false),
                    Codigo_presupuestarioId = table.Column<int>(type: "integer", nullable: false),
                    ClaseId = table.Column<int>(type: "integer", nullable: false),
                    SubclaseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidas_presupuestarias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partidas_presupuestarias_Clases_ClaseId",
                        column: x => x.ClaseId,
                        principalTable: "Clases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Partidas_presupuestarias_Codigos_presupuestarios_Codigo_pre~",
                        column: x => x.Codigo_presupuestarioId,
                        principalTable: "Codigos_presupuestarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Partidas_presupuestarias_Subclases_SubclaseId",
                        column: x => x.SubclaseId,
                        principalTable: "Subclases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Partidas_presupuestarias_Unidades_unidadId",
                        column: x => x.unidadId,
                        principalTable: "Unidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bienes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    F_adq = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Valor_unitario = table.Column<double>(type: "double precision", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Nro_expediente = table.Column<string>(type: "text", nullable: false),
                    Subtipo_adquisicionId = table.Column<int>(type: "integer", nullable: false),
                    Tipo_adquisicionId = table.Column<int>(type: "integer", nullable: false),
                    Codigo_presupuestarioId = table.Column<int>(type: "integer", nullable: false),
                    Partida_presupuestariaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bienes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bienes_Codigos_presupuestarios_Codigo_presupuestarioId",
                        column: x => x.Codigo_presupuestarioId,
                        principalTable: "Codigos_presupuestarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bienes_Partidas_presupuestarias_Partida_presupuestariaId",
                        column: x => x.Partida_presupuestariaId,
                        principalTable: "Partidas_presupuestarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bienes_Subtipos_adquisicion_Subtipo_adquisicionId",
                        column: x => x.Subtipo_adquisicionId,
                        principalTable: "Subtipos_adquisicion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bienes_Tipos_adquisicion_Tipo_adquisicionId",
                        column: x => x.Tipo_adquisicionId,
                        principalTable: "Tipos_adquisicion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bienes_de_uso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BienId = table.Column<int>(type: "integer", nullable: false),
                    Estado_bien_de_usoId = table.Column<int>(type: "integer", nullable: false),
                    Nro_expediente_baja = table.Column<string>(type: "text", nullable: true),
                    Tipo_BajaId = table.Column<int>(type: "integer", nullable: true),
                    MuebleId = table.Column<int>(type: "integer", nullable: true),
                    InmuebleId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bienes_de_uso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bienes_de_uso_Bienes_BienId",
                        column: x => x.BienId,
                        principalTable: "Bienes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bienes_de_uso_Estados_bienes_de_uso_Estado_bien_de_usoId",
                        column: x => x.Estado_bien_de_usoId,
                        principalTable: "Estados_bienes_de_uso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bienes_de_uso_Inmuebles_InmuebleId",
                        column: x => x.InmuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bienes_de_uso_Muebles_MuebleId",
                        column: x => x.MuebleId,
                        principalTable: "Muebles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bienes_de_uso_Tipos_baja_Tipo_BajaId",
                        column: x => x.Tipo_BajaId,
                        principalTable: "Tipos_baja",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Observaciones_bien",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Observacion = table.Column<string>(type: "text", nullable: false),
                    BienId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observaciones_bien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Observaciones_bien_Bienes_BienId",
                        column: x => x.BienId,
                        principalTable: "Bienes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registros_forograficos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uri_imagen = table.Column<string>(type: "text", nullable: false),
                    MuebleId = table.Column<int>(type: "integer", nullable: true),
                    bienId = table.Column<int>(type: "integer", nullable: true),
                    ficha_TecnicaId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros_forograficos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registros_forograficos_Bienes_bienId",
                        column: x => x.bienId,
                        principalTable: "Bienes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Registros_forograficos_Fichas_tecnicas_ficha_TecnicaId",
                        column: x => x.ficha_TecnicaId,
                        principalTable: "Fichas_tecnicas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Registros_forograficos_Inmuebles_MuebleId",
                        column: x => x.MuebleId,
                        principalTable: "Inmuebles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Historicos_cambio_unidad_bien_de_uso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Unidad_actualId = table.Column<int>(type: "integer", nullable: false),
                    Unidad_anteriorId = table.Column<int>(type: "integer", nullable: false),
                    usuarioId = table.Column<int>(type: "integer", nullable: false),
                    bienId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos_cambio_unidad_bien_de_uso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_cambio_unidad_bien_de_uso_Bienes_de_uso_bienId",
                        column: x => x.bienId,
                        principalTable: "Bienes_de_uso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_cambio_unidad_bien_de_uso_Unidades_Unidad_actual~",
                        column: x => x.Unidad_actualId,
                        principalTable: "Unidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_cambio_unidad_bien_de_uso_Unidades_Unidad_anteri~",
                        column: x => x.Unidad_anteriorId,
                        principalTable: "Unidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_cambio_unidad_bien_de_uso_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Historicos_estado_bien_de_uso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    usuarioId = table.Column<int>(type: "integer", nullable: false),
                    bien_de_usoId = table.Column<int>(type: "integer", nullable: false),
                    EstadoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos_estado_bien_de_uso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_bien_de_uso_Bienes_de_uso_bien_de_usoId",
                        column: x => x.bien_de_usoId,
                        principalTable: "Bienes_de_uso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_bien_de_uso_Estados_bienes_de_uso_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados_bienes_de_uso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Historicos_estado_bien_de_uso_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agentes_asociados_Tarjeta_combustibleId",
                table: "Agentes_asociados",
                column: "Tarjeta_combustibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Alertas_recuento_fisico_Estado_alerta_recuento_fisicoId",
                table: "Alertas_recuento_fisico",
                column: "Estado_alerta_recuento_fisicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alertas_recuento_fisico_UnidadId",
                table: "Alertas_recuento_fisico",
                column: "UnidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Bienes_Codigo_presupuestarioId",
                table: "Bienes",
                column: "Codigo_presupuestarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Bienes_Partida_presupuestariaId",
                table: "Bienes",
                column: "Partida_presupuestariaId");

            migrationBuilder.CreateIndex(
                name: "IX_Bienes_Subtipo_adquisicionId",
                table: "Bienes",
                column: "Subtipo_adquisicionId");

            migrationBuilder.CreateIndex(
                name: "IX_Bienes_Tipo_adquisicionId",
                table: "Bienes",
                column: "Tipo_adquisicionId");

            migrationBuilder.CreateIndex(
                name: "IX_Bienes_de_uso_BienId",
                table: "Bienes_de_uso",
                column: "BienId");

            migrationBuilder.CreateIndex(
                name: "IX_Bienes_de_uso_Estado_bien_de_usoId",
                table: "Bienes_de_uso",
                column: "Estado_bien_de_usoId");

            migrationBuilder.CreateIndex(
                name: "IX_Bienes_de_uso_InmuebleId",
                table: "Bienes_de_uso",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Bienes_de_uso_MuebleId",
                table: "Bienes_de_uso",
                column: "MuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Bienes_de_uso_Tipo_BajaId",
                table: "Bienes_de_uso",
                column: "Tipo_BajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clases_Codigo_presupuestarioId",
                table: "Clases",
                column: "Codigo_presupuestarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Codigos_presupuestarios_Vida_util_id",
                table: "Codigos_presupuestarios",
                column: "Vida_util_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Codigos_qr_Inmueble_id",
                table: "Codigos_qr",
                column: "Inmueble_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Codigos_qr_Mueble_id",
                table: "Codigos_qr",
                column: "Mueble_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dispositivos_telepase_Estado_dispositivo_telepaseId",
                table: "Dispositivos_telepase",
                column: "Estado_dispositivo_telepaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Dispositivos_telepase_Ficha_tecnicaId",
                table: "Dispositivos_telepase",
                column: "Ficha_tecnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_digitales_InmuebleId",
                table: "Documentos_digitales",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_digitales_TipoId",
                table: "Documentos_digitales",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Fichas_tecnicas_CombustibleId",
                table: "Fichas_tecnicas",
                column: "CombustibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Fichas_tecnicas_Estado_afectacionId",
                table: "Fichas_tecnicas",
                column: "Estado_afectacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Fichas_tecnicas_Estado_operativoId",
                table: "Fichas_tecnicas",
                column: "Estado_operativoId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_cambio_unidad_bien_de_uso_bienId",
                table: "Historicos_cambio_unidad_bien_de_uso",
                column: "bienId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_cambio_unidad_bien_de_uso_Unidad_actualId",
                table: "Historicos_cambio_unidad_bien_de_uso",
                column: "Unidad_actualId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_cambio_unidad_bien_de_uso_Unidad_anteriorId",
                table: "Historicos_cambio_unidad_bien_de_uso",
                column: "Unidad_anteriorId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_cambio_unidad_bien_de_uso_usuarioId",
                table: "Historicos_cambio_unidad_bien_de_uso",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_afectacion_EstadoId",
                table: "Historicos_estado_afectacion",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_afectacion_ficha_tecnicaId",
                table: "Historicos_estado_afectacion",
                column: "ficha_tecnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_afectacion_usuarioId",
                table: "Historicos_estado_afectacion",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_alerta_recuento_fisico_AlertaId",
                table: "Historicos_estado_alerta_recuento_fisico",
                column: "AlertaId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_alerta_recuento_fisico_EstadoId",
                table: "Historicos_estado_alerta_recuento_fisico",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_alerta_recuento_fisico_usuarioId",
                table: "Historicos_estado_alerta_recuento_fisico",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_bien_de_uso_bien_de_usoId",
                table: "Historicos_estado_bien_de_uso",
                column: "bien_de_usoId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_bien_de_uso_EstadoId",
                table: "Historicos_estado_bien_de_uso",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_bien_de_uso_usuarioId",
                table: "Historicos_estado_bien_de_uso",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_dispositivo_telepase_dispositivo_telepase~",
                table: "Historicos_estado_dispositivo_telepase",
                column: "dispositivo_telepaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_dispositivo_telepase_EstadoId",
                table: "Historicos_estado_dispositivo_telepase",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_dispositivo_telepase_usuarioId",
                table: "Historicos_estado_dispositivo_telepase",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_operativo_EstadoId",
                table: "Historicos_estado_operativo",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_operativo_ficha_tecnicaId",
                table: "Historicos_estado_operativo",
                column: "ficha_tecnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_operativo_usuarioId",
                table: "Historicos_estado_operativo",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_sesion_EstadoId",
                table: "Historicos_estado_sesion",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_sesion_usuarioId",
                table: "Historicos_estado_sesion",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_tarjeta_combustible_EstadoId",
                table: "Historicos_estado_tarjeta_combustible",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_tarjeta_combustible_tarjeta_combustibleId",
                table: "Historicos_estado_tarjeta_combustible",
                column: "tarjeta_combustibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_tarjeta_combustible_usuarioId",
                table: "Historicos_estado_tarjeta_combustible",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_usuario_EstadoId",
                table: "Historicos_estado_usuario",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_estado_usuario_usuarioId",
                table: "Historicos_estado_usuario",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_situacion_dominial_inmuebleId",
                table: "Historicos_situacion_dominial",
                column: "inmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_situacion_dominial_SituacionId",
                table: "Historicos_situacion_dominial",
                column: "SituacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_situacion_dominial_usuarioId",
                table: "Historicos_situacion_dominial",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Inmuebles_situacion_DominialId",
                table: "Inmuebles",
                column: "situacion_DominialId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantenimientos_Ficha_tecnicaId",
                table: "Mantenimientos",
                column: "Ficha_tecnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantenimientos_Taller_mecanicoId",
                table: "Mantenimientos",
                column: "Taller_mecanicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Modelos_MarcaId",
                table: "Modelos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Muebles_Vehiculo_id",
                table: "Muebles",
                column: "Vehiculo_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Observaciones_bien_BienId",
                table: "Observaciones_bien",
                column: "BienId");

            migrationBuilder.CreateIndex(
                name: "IX_Observaciones_inmueble_InmuebleId",
                table: "Observaciones_inmueble",
                column: "InmuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Observaciones_muebles_MuebleId",
                table: "Observaciones_muebles",
                column: "MuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidas_presupuestarias_ClaseId",
                table: "Partidas_presupuestarias",
                column: "ClaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidas_presupuestarias_Codigo_presupuestarioId",
                table: "Partidas_presupuestarias",
                column: "Codigo_presupuestarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidas_presupuestarias_SubclaseId",
                table: "Partidas_presupuestarias",
                column: "SubclaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Partidas_presupuestarias_unidadId",
                table: "Partidas_presupuestarias",
                column: "unidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_forograficos_bienId",
                table: "Registros_forograficos",
                column: "bienId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_forograficos_ficha_TecnicaId",
                table: "Registros_forograficos",
                column: "ficha_TecnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_forograficos_MuebleId",
                table: "Registros_forograficos",
                column: "MuebleId");

            migrationBuilder.CreateIndex(
                name: "IX_Rel_perfiles_roles_perfilId",
                table: "Rel_perfiles_roles",
                column: "perfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Rel_perfiles_roles_rolId",
                table: "Rel_perfiles_roles",
                column: "rolId");

            migrationBuilder.CreateIndex(
                name: "IX_Subclases_claseId",
                table: "Subclases",
                column: "claseId");

            migrationBuilder.CreateIndex(
                name: "IX_Subtipos_adquisicion_Tipo_AdquisicionId",
                table: "Subtipos_adquisicion",
                column: "Tipo_AdquisicionId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjetas_combustible_Estado_tarjeta_combustibleId",
                table: "Tarjetas_combustible",
                column: "Estado_tarjeta_combustibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjetas_combustible_Ficha_tecnicaId",
                table: "Tarjetas_combustible",
                column: "Ficha_tecnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_estado_sesionId",
                table: "Usuarios",
                column: "estado_sesionId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_estado_usuarioId",
                table: "Usuarios",
                column: "estado_usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_perfilId",
                table: "Usuarios",
                column: "perfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_Ficha_tecnica_id",
                table: "Vehiculos",
                column: "Ficha_tecnica_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_MarcaId",
                table: "Vehiculos",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ModeloId",
                table: "Vehiculos",
                column: "ModeloId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_seguroId",
                table: "Vehiculos",
                column: "seguroId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_Tipo_vehiculoId",
                table: "Vehiculos",
                column: "Tipo_vehiculoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agentes_asociados");

            migrationBuilder.DropTable(
                name: "Codigos_qr");

            migrationBuilder.DropTable(
                name: "Documentos_digitales");

            migrationBuilder.DropTable(
                name: "Historicos_cambio_unidad_bien_de_uso");

            migrationBuilder.DropTable(
                name: "Historicos_estado_afectacion");

            migrationBuilder.DropTable(
                name: "Historicos_estado_alerta_recuento_fisico");

            migrationBuilder.DropTable(
                name: "Historicos_estado_bien_de_uso");

            migrationBuilder.DropTable(
                name: "Historicos_estado_dispositivo_telepase");

            migrationBuilder.DropTable(
                name: "Historicos_estado_operativo");

            migrationBuilder.DropTable(
                name: "Historicos_estado_sesion");

            migrationBuilder.DropTable(
                name: "Historicos_estado_tarjeta_combustible");

            migrationBuilder.DropTable(
                name: "Historicos_estado_usuario");

            migrationBuilder.DropTable(
                name: "Historicos_situacion_dominial");

            migrationBuilder.DropTable(
                name: "Mantenimientos");

            migrationBuilder.DropTable(
                name: "Observaciones_bien");

            migrationBuilder.DropTable(
                name: "Observaciones_inmueble");

            migrationBuilder.DropTable(
                name: "Observaciones_muebles");

            migrationBuilder.DropTable(
                name: "Registros_forograficos");

            migrationBuilder.DropTable(
                name: "Rel_perfiles_roles");

            migrationBuilder.DropTable(
                name: "Tipos_estado_historicos");

            migrationBuilder.DropTable(
                name: "Tipos_documentos_digitales");

            migrationBuilder.DropTable(
                name: "Alertas_recuento_fisico");

            migrationBuilder.DropTable(
                name: "Bienes_de_uso");

            migrationBuilder.DropTable(
                name: "Dispositivos_telepase");

            migrationBuilder.DropTable(
                name: "Tarjetas_combustible");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Talleres_mecanicos");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Estados_alerta_recuento_fisico");

            migrationBuilder.DropTable(
                name: "Bienes");

            migrationBuilder.DropTable(
                name: "Estados_bienes_de_uso");

            migrationBuilder.DropTable(
                name: "Inmuebles");

            migrationBuilder.DropTable(
                name: "Muebles");

            migrationBuilder.DropTable(
                name: "Tipos_baja");

            migrationBuilder.DropTable(
                name: "Estados_dispositivos_telepase");

            migrationBuilder.DropTable(
                name: "Estados_tarjetas_combustible");

            migrationBuilder.DropTable(
                name: "Estados_sesion");

            migrationBuilder.DropTable(
                name: "Estados_usuarios");

            migrationBuilder.DropTable(
                name: "Perfiles");

            migrationBuilder.DropTable(
                name: "Partidas_presupuestarias");

            migrationBuilder.DropTable(
                name: "Subtipos_adquisicion");

            migrationBuilder.DropTable(
                name: "Situaciones_dominiales");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Subclases");

            migrationBuilder.DropTable(
                name: "Unidades");

            migrationBuilder.DropTable(
                name: "Tipos_adquisicion");

            migrationBuilder.DropTable(
                name: "Fichas_tecnicas");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropTable(
                name: "Seguros");

            migrationBuilder.DropTable(
                name: "Tipos_vehiculos");

            migrationBuilder.DropTable(
                name: "Clases");

            migrationBuilder.DropTable(
                name: "Combustibles");

            migrationBuilder.DropTable(
                name: "Estados_afectacion");

            migrationBuilder.DropTable(
                name: "Estados_operativos");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Codigos_presupuestarios");

            migrationBuilder.DropTable(
                name: "Vidas_utiles");
        }
    }
}
