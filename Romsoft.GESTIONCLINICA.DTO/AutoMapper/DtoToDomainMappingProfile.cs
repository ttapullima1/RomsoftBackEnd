using AutoMapper;
using Romsoft.GESTIONCLINICA.Entidades;

namespace Romsoft.GESTIONCLINICA.DTO.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DtoToDomainMappingProfile"; }
        }
        protected override void Configure()
        {
            //SEG_USUARIO
            Mapper.CreateMap<TABLAS.SEG_USUARIO.SEG_USUARIODTO, Entidades.SEG_USUARIO.SEG_USUARIO>();
            Mapper.CreateMap<TABLAS.SEG_USUARIO.SEG_USUARIOLoginDTO, Entidades.SEG_USUARIO.SEG_USUARIO>();

            //SEG_ROL
            Mapper.CreateMap<TABLAS.SEG_ROL.SEG_ROLDTO, Entidades.SEG_USUARIO.SEG_USUARIO>();

            // TIPO ESTADO
            Mapper.CreateMap<TABLAS.TIPO_ESTADO.TIPO_ESTADODTO, Entidades.TIPO_ESTADO.TIPO_ESTADO>();

            // ADM_OCUPACION
            Mapper.CreateMap<TABLAS.ADM_OCUPACION.ADM_OCUPACIONDTO, Entidades.ADM_OCUPACION.ADM_OCUPACION>()
                .ForMember(p => p.id_usuarioCreacion, x => x.MapFrom(g => g.IdUsuarioActual))
                .ForMember(p => p.id_usuarioModifica, x => x.MapFrom(g => g.IdUsuarioActual));

            ////CVN_TARIFARIO_SEGUS
            Mapper.CreateMap<TABLAS.CVN_TARIFARIO_SEGUS.CVN_TARIFARIO_SEGUSDTO, Entidades.CVN_TARIFARIO_SEGUS.CVN_TARIFARIO_SEGUS>()
                .ForMember(p => p.id_usuarioCreacion, x => x.MapFrom(g => g.IdUsuarioActual))
                .ForMember(p => p.id_usuarioModifica, x => x.MapFrom(g => g.IdUsuarioActual));

            Mapper.CreateMap<TABLAS.CVN_TARIFARIO_SEGUS.CVN_TARIFARIO_SEGUSDTO, Entidades.CVN_TARIFARIO_SEGUS.CVN_TARIFARIO_LISTA>()
                .ForMember(p => p.id_tarifario_segus, x => x.MapFrom(g => g.id_tarifario_segus))
                .ForMember(p => p.c_codigo, x => x.MapFrom(g => g.c_codigo))
                .ForMember(p => p.c_codigo_susalud, x => x.MapFrom(g => g.c_codigo_susalud))
                .ForMember(p => p.t_descripcion_esp, x => x.MapFrom(g => g.t_descripcion_esp))
                .ForMember(p => p.t_descripcion_eng, x => x.MapFrom(g => g.t_descripcion_eng))
                .ForMember(p => p.t_observacion, x => x.MapFrom(g => g.t_observacion))
                .ForMember(p => p.t_clasificacion, x => x.MapFrom(g => g.t_clasificacion))
                .ForMember(p => p.estado, x => x.MapFrom(g => g.estado));

            // CVN_CLASIFICACION_SEGUS
            Mapper.CreateMap<TABLAS.CVN_CLASIFICACION_SEGUS.CVN_CLASIFICACION_SEGUSDTO, Entidades.CVN_CLASIFICACION_SEGUS.CVN_CLASIFICACION_SEGUS>();

            //CVN_CLASIFICACION_SUSALUD
            Mapper.CreateMap<TABLAS.CVN_CLASIFICACION_SUSALUD.CVN_CLASIFICACION_SUSALUDDTO, Entidades.CVN_CLASIFICACION_SUSALUD.CVN_CLASIFICACION_SUSALUD>();

            //CVN_CLASIFICACION_SUSALUD_OD
            Mapper.CreateMap<TABLAS.CVN_CLASIFICACION_SUSALUD_OD.CVN_CLASIFICACION_SUSALUD_ODDTO, Entidades.CVN_CLASIFICACION_SUSALUD_OD.CVN_CLASIFICACION_SUSALUD_OD>();
            //CVN_TIPO_PRECIO
            Mapper.CreateMap<TABLAS.CVN_TIPO_PRECIO.CVN_TIPO_PRECIODTO, Entidades.CVN_TIPO_PRECIO.CVN_TIPO_PRECIO>();
            //CON_CENTRO_COSTO
            Mapper.CreateMap<TABLAS.CON_CENTRO_COSTO.CON_CENTRO_COSTODTO, Entidades.CON_CENTRO_COSTO.CON_CENTRO_COSTO>();
            //CON_CUENTA_CONTABLE
            Mapper.CreateMap<TABLAS.CON_CUENTA_CONTABLE.CON_CUENTA_CONTABLEDTO, Entidades.CON_CUENTA_CONTABLE.CON_CUENTA_CONTABLE>();
            //CVN_TARIFARIO_SEGUS_PARTICIPANTE
            Mapper.CreateMap<TABLAS.CVN_TARIFARIO_SEGUS_PARTICIPANTE.CVN_TARIFARIO_SEGUS_PARTICIPANTEDTO, Entidades.CVN_TARIFARIO_SEGUS_PARTICIPANTE.CVN_TARIFARIO_SEGUS_PARTICIPANTE>();
            //CVN_CATEGORIA_PAGO
            Mapper.CreateMap<TABLAS.CVN_CATEGORIA_PAGO.CVN_CATEGORIA_PAGODTO, Entidades.CVN_CATEGORIA_PAGO.CVN_CATEGORIA_PAGO>();
            ////CVN_CATEGORIA_PAGO_PRECIO
            Mapper.CreateMap<TABLAS.CVN_CATEGORIA_PAGO_PRECIO.CVN_CATEGORIA_PAGO_PRECIODTO, Entidades.CVN_CATEGORIA_PAGO_PRECIO.CVN_CATEGORIA_PAGO_PRECIO>();

            //// CON_CONTACTO
            Mapper.CreateMap<TABLAS.CON_CONTACTO.CON_CONTACTODTO, Entidades.CON_CONTACTO.CON_CONTACTO>();

        }

    }
 
}
