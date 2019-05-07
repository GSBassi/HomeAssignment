using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HomeAssignment.Authorization;
using HomeAssignment.CMServices.DTO;
using HomeAssignment.Models;

namespace HomeAssignment
{
    [DependsOn(
        typeof(HomeAssignmentCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HomeAssignmentApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HomeAssignmentAuthorizationProvider>();
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper => { mapper.CreateMap<CreateContentInput, CMSContent>().ReverseMap(); });
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HomeAssignmentApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
