using Learn.Wpf.Core.ViewModels;
using Ninject;

namespace Learn.Wpf.Core.IoC
{
   
    /// <summary>
    /// The IoC Container ofr our application
    /// </summary>
    public static class IoC
    {
        /// <summary>
        /// The kernel of the IoC container
        /// </summary>
        public static IKernel Kernel { get; private set; }= new StandardKernel();

        /// <summary>
        /// Gets a Service from the IoC from the specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Get<T>() => Kernel.Get<T>();

        /// <summary>
        /// Sets up the IoC container
        /// </summary>
        public static void Setup()
        {
            //ViewModels
            BindViewModels();
        }

        /// <summary>
        /// Binds all singleton view models
        /// </summary>
        private static void BindViewModels()
        {
            //Kernel.Bind<ApplicationViewModel>().ToSelf().InSingletonScope();
            //Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel{CurrentPage = ApplicationPage.Login});
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());
        }


    }
}
