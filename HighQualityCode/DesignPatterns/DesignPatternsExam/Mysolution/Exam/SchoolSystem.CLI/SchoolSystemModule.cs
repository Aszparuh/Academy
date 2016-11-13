using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;
using Ninject.Modules;
using SchoolSystem.Cli.Configuration;
using SchoolSystem.Cli.Extension;
using SchoolSystem.Framework.Core;
using SchoolSystem.Framework.Core.Commands;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Core.Contracts;
using SchoolSystem.Framework.Core.Factories;
using SchoolSystem.Framework.Core.Providers;
using SchoolSystem.Framework.Core.Repositories;
using SchoolSystem.Framework.Core.Repositories.Contracts;
using System.IO;
using System.Reflection;

namespace SchoolSystem.Cli
{
    public class SchoolSystemModule : NinjectModule
    {
        private const string CreateStudentCommandName = "CreateStudent";
        private const string CreateTeacherCommandName = "CreateTeacher";
        private const string RemoveStudentCommandName = "RemoveStudent";
        private const string RemoveTeacherCommandName = "RemoveTeacher";
        private const string StudentListMarksCommandName = "StudentListMarks";
        private const string TeacherAddMarkCommandName = "TeacherAddMark";

        public override void Load()
        {
            Kernel.Bind(x =>
            {
                x.FromAssembliesInPath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                .SelectAllClasses()
                .BindDefaultInterface();
            });

            this.Bind<IReader>().To<ConsoleReaderProvider>();
            this.Bind<IWriter>().To<ConsoleWriterProvider>();
            this.Bind<IParser>().To<CommandParserProvider>();
            this.Bind<IStudentFactory>().ToFactory().InSingletonScope();
            this.Bind<ITeacherFactory>().ToFactory().InSingletonScope();
            this.Bind<IMarkFactory>().ToFactory().InSingletonScope();

            this.Bind<ICommandFactory>()
            .ToFactory(() => new UseFirstArgumentAsNameInstanceProvider());
            this.Bind<ICommand>().To<CreateStudentCommand>().Named(CreateStudentCommandName);
            this.Bind<ICommand>().To<CreateTeacherCommand>().Named(CreateTeacherCommandName);
            this.Bind<ICommand>().To<RemoveStudentCommand>().Named(RemoveStudentCommandName);
            this.Bind<ICommand>().To<RemoveTeacherCommand>().Named(RemoveTeacherCommandName);
            this.Bind<ICommand>().To<StudentListMarksCommand>().Named(StudentListMarksCommandName);
            this.Bind<ICommand>().To<TeacherAddMarkCommand>().Named(TeacherAddMarkCommandName);

            this.Bind<IRepository>().To<SchoolRepository>().InSingletonScope();
            this.Bind<IStudentIdProvider>().To<StudentIdCreator>().InSingletonScope();
            this.Bind<ITeacherIdProvider>().To<TeacherIdCreator>().InSingletonScope();
                
                IConfigurationProvider configurationProvider = Kernel.Get<IConfigurationProvider>();
            if (configurationProvider.IsTestEnvironment)
            {
            }
        }
    }
}