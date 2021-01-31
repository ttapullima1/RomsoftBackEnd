using AutoMapper;
using Romsoft.GESTIONCLINICA.Entidades;

namespace Romsoft.GESTIONCLINICA.DTO.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToDtoMappingProfile"; }
        }

        protected override void Configure()
        {
            //SEG_USAURIO
            Mapper.CreateMap<Entidades.SEG_USUARIO.SEG_USUARIO, TABLAS.SEG_USUARIO.SEG_USUARIODTO>();
            Mapper.CreateMap<Entidades.SEG_USUARIO.SEG_USUARIO, TABLAS.SEG_USUARIO.SEG_USUARIOLoginDTO>();

            //SEG_ROL
            Mapper.CreateMap<Entidades.SEG_ROL.SEG_ROL, TABLAS.SEG_ROL.SEG_ROLDTO>();

            // TIPO ESTADO
            Mapper.CreateMap<Entidades.TIPO_ESTADO.TIPO_ESTADO, TABLAS.TIPO_ESTADO.TIPO_ESTADODTO>();

            //ADM_OCUPACION
            Mapper.CreateMap<Entidades.ADM_OCUPACION.ADM_OCUPACION, TABLAS.ADM_OCUPACION.ADM_OCUPACIONDTO>()
                .ForMember(p => p.IdUsuarioActual, x => x.MapFrom(g => g.id_usuarioCreacion))
                .ForMember(p => p.IdUsuarioActual, x => x.MapFrom(g => g.id_usuarioModifica));

            //CVN_TARIFARIO_SEGUS
            Mapper.CreateMap<Entidades.CVN_TARIFARIO_SEGUS.CVN_TARIFARIO_SEGUS, TABLAS.CVN_TARIFARIO_SEGUS.CVN_TARIFARIO_SEGUSDTO>()
                .ForMember(p => p.IdUsuarioActual, x => x.MapFrom(g => g.id_usuarioCreacion))
                .ForMember(p => p.IdUsuarioActual, x => x.MapFrom(g => g.id_usuarioModifica));

            Mapper.CreateMap<Entidades.CVN_TARIFARIO_SEGUS.CVN_TARIFARIO_SEGUS, TABLAS.CVN_TARIFARIO_SEGUS.CVN_TARIFARIO_LISTADTO>()
                .ForMember(p => p.id_tarifario_segus, x => x.MapFrom(g => g.id_tarifario_segus))
                .ForMember(p => p.c_codigo, x => x.MapFrom(g => g.c_codigo))
                .ForMember(p => p.c_codigo_susalud, x => x.MapFrom(g => g.c_codigo_susalud))
                .ForMember(p => p.t_descripcion_esp, x => x.MapFrom(g => g.t_descripcion_esp))
                .ForMember(p => p.t_descripcion_eng, x => x.MapFrom(g => g.t_descripcion_eng))
                .ForMember(p => p.t_observacion, x => x.MapFrom(g => g.t_observacion))
                .ForMember(p => p.t_clasificacion, x => x.MapFrom(g => g.t_clasificacion))
                .ForMember(p => p.estado, x => x.MapFrom(g => g.estado));

            // CVN_CLASIFICACION_SEGUS
            Mapper.CreateMap<Entidades.CVN_CLASIFICACION_SEGUS.CVN_CLASIFICACION_SEGUS, TABLAS.CVN_CLASIFICACION_SEGUS.CVN_CLASIFICACION_SEGUSDTO>();

            //CVN_CLASIFICACION_SUSALUD
            Mapper.CreateMap<Entidades.CVN_CLASIFICACION_SUSALUD.CVN_CLASIFICACION_SUSALUD, TABLAS.CVN_CLASIFICACION_SUSALUD.CVN_CLASIFICACION_SUSALUDDTO>();

            // CVN_CLASIFICACION_SUSALUD_OD
            Mapper.CreateMap<Entidades.CVN_CLASIFICACION_SUSALUD_OD.CVN_CLASIFICACION_SUSALUD_OD, TABLAS.CVN_CLASIFICACION_SUSALUD_OD.CVN_CLASIFICACION_SUSALUD_ODDTO>();
            //CVN_TIPO_PRECIO
            Mapper.CreateMap<Entidades.CVN_TIPO_PRECIO.CVN_TIPO_PRECIO, TABLAS.CVN_TIPO_PRECIO.CVN_TIPO_PRECIODTO>();
            //CON_CENTRO_COSTO
            Mapper.CreateMap<Entidades.CON_CENTRO_COSTO.CON_CENTRO_COSTO, TABLAS.CON_CENTRO_COSTO.CON_CENTRO_COSTODTO>();
            //CON_CUENTA_CONTABLE
            Mapper.CreateMap<Entidades.CON_CUENTA_CONTABLE.CON_CUENTA_CONTABLE, TABLAS.CON_CUENTA_CONTABLE.CON_CUENTA_CONTABLEDTO>();
            //CVN_TARIFARIO_SEGUS_PARTICIPANTE
            Mapper.CreateMap<Entidades.CVN_TARIFARIO_SEGUS_PARTICIPANTE.CVN_TARIFARIO_SEGUS_PARTICIPANTE, TABLAS.CVN_TARIFARIO_SEGUS_PARTICIPANTE.CVN_TARIFARIO_SEGUS_PARTICIPANTEDTO>();
            //CVN_CATEGORIA_PAGO
            Mapper.CreateMap<Entidades.CVN_CATEGORIA_PAGO.CVN_CATEGORIA_PAGO, TABLAS.CVN_CATEGORIA_PAGO.CVN_CATEGORIA_PAGODTO>();
            //CVN_CATEGORIA_PAGO_PRECIO
            Mapper.CreateMap<Entidades.CVN_CATEGORIA_PAGO_PRECIO.CVN_CATEGORIA_PAGO_PRECIO, TABLAS.CVN_CATEGORIA_PAGO_PRECIO.CVN_CATEGORIA_PAGO_PRECIODTO>();

            // CON_CONTACTO
            Mapper.CreateMap<Entidades.CON_CONTACTO.CON_CONTACTO, TABLAS.CON_CONTACTO.CON_CONTACTODTO>();


        }

    }
}
