using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HomeAssignment.Configuration;
using HomeAssignment.EntityFrameworkCore;
using HomeAssignment.Migrator.DependencyInjection;

namespace HomeAssignment.Migrator
{
    [DependsOn(typeof(HomeAssignmentEntityFrameworkModule))]
    public class HomeAssignmentMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public HomeAssignmentMigratorModule(HomeAssignmentEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(HomeAssignmentMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                HomeAssignmentConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HomeAssignmentMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
