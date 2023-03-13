using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.CCS;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Helper.FileHelper;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PrinterManager>().As<IPrinterService>().SingleInstance();
            builder.RegisterType<EfPrinterDal>().As<IPrinterDal>().SingleInstance();

            builder.RegisterType<TonerManager>().As<ITonerService>().SingleInstance();
            builder.RegisterType<EfTonerDal>().As<ITonerDal>().SingleInstance();

            builder.RegisterType<TonerModelManager>().As<ITonerModelService>().SingleInstance();
            builder.RegisterType<EfTonerModelDal>().As<ITonerModelDal>().SingleInstance();

            builder.RegisterType<PrinterModelManager>().As<IPrinterModelService>().SingleInstance();
            builder.RegisterType<EfPrinterModelDal>().As<IPrinterModelDal>().SingleInstance();

            builder.RegisterType<TonerRefillingManager>().As<ITonerRefillingService>().SingleInstance();
            builder.RegisterType<EfTonerRefillingDal>().As<ITonerRefillingDal>().SingleInstance();

            builder.RegisterType<TonerBrandManager>().As<ITonerBrandService>().SingleInstance();
            builder.RegisterType<EfTonerBrandDal>().As<ITonerBrandDal>().SingleInstance();

            builder.RegisterType<PrinterBrandManager>().As<IPrinterBrandService>().SingleInstance();
            builder.RegisterType<EfPrinterBrandDal>().As<IPrinterBrandDal>().SingleInstance();

            builder.RegisterType<TonerTrackingManager>().As<ITonerTrackingService>().SingleInstance();
            builder.RegisterType<EfTonerTrackingDal>().As<ITonerTrackingDal>().SingleInstance();

            builder.RegisterType<PrinterImageManager>().As<IPrinterImageService>().SingleInstance();
            builder.RegisterType<EfPrinterImageDal>().As<IPrinterImageDal>().SingleInstance();

            builder.RegisterType<FileHelperManager>().As<IFileHelper>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

           



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
