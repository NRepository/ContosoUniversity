﻿// <auto-generated />
/* ************************************************************
 * 
 * 
 * AUTO GENERERATED - DO NOT ALTER
 * 
 * 
 * ************************************************************/ 
namespace ContosoUniversity.TestKit.Factories
{
	using Moq;
	using ContosoUniversity.Domain.Core.Behaviours;
	using ContosoUniversity.Domain.Core.Behaviours.CourseApplicationService;
	using ContosoUniversity.Domain.Core.Behaviours.DepartmentApplicationService;
	using ContosoUniversity.Domain.Core.Behaviours.InstructorApplicationService;
	using ContosoUniversity.Domain.Core.Behaviours.StudentApplicationService;
	using ContosoUniversity.Domain.Services.CourseApplicationService;
	using ContosoUniversity.Web.Mvc.Features.Course;
	using ContosoUniversity.Web.Mvc.Features.Department;
	using ContosoUniversity.Web.Mvc.Features.Instructor;
	using ContosoUniversity.Web.Mvc.Features.Student;
	using NRepository.Core;
	using NRepository.Core.Query;

    // Auto generated
	public partial class CreateCourseHandlerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public CreateCourseHandlerFactory()
            : this(MockBehavior.Default)
        {
        }

        public CreateCourseHandlerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			RepositoryMock = new Mock<IRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// IRepository
		private IRepository _IRepository;
        public Mock<IRepository> RepositoryMock { get; set; }
        public IRepository _GetRepository() { return _IRepository ?? RepositoryMock.Object; }
	    public IRepository _SetRepository(IRepository obj){ _IRepository = obj; return obj;}

	    public CreateCourseHandler  Object
        {
            get
            {
                return new CreateCourseHandler(_GetRepository());
			}
        }

		public void VerifyAll()
		{
			RepositoryMock.VerifyAll();
		}
	}


    // Auto generated
	public partial class UpdateCourseHandlerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public UpdateCourseHandlerFactory()
            : this(MockBehavior.Default)
        {
        }

        public UpdateCourseHandlerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			RepositoryMock = new Mock<IRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// IRepository
		private IRepository _IRepository;
        public Mock<IRepository> RepositoryMock { get; set; }
        public IRepository _GetRepository() { return _IRepository ?? RepositoryMock.Object; }
	    public IRepository _SetRepository(IRepository obj){ _IRepository = obj; return obj;}

	    public UpdateCourseHandler  Object
        {
            get
            {
                return new UpdateCourseHandler(_GetRepository());
			}
        }

		public void VerifyAll()
		{
			RepositoryMock.VerifyAll();
		}
	}


    // Auto generated
	public partial class DeleteDepartmentHandlerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public DeleteDepartmentHandlerFactory()
            : this(MockBehavior.Default)
        {
        }

        public DeleteDepartmentHandlerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			RepositoryMock = new Mock<IRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// IRepository
		private IRepository _IRepository;
        public Mock<IRepository> RepositoryMock { get; set; }
        public IRepository _GetRepository() { return _IRepository ?? RepositoryMock.Object; }
	    public IRepository _SetRepository(IRepository obj){ _IRepository = obj; return obj;}

	    public DeleteDepartmentHandler  Object
        {
            get
            {
                return new DeleteDepartmentHandler(_GetRepository());
			}
        }

		public void VerifyAll()
		{
			RepositoryMock.VerifyAll();
		}
	}


    // Auto generated
	public partial class CreateDepartmentHandlerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public CreateDepartmentHandlerFactory()
            : this(MockBehavior.Default)
        {
        }

        public CreateDepartmentHandlerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			RepositoryMock = new Mock<IRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// IRepository
		private IRepository _IRepository;
        public Mock<IRepository> RepositoryMock { get; set; }
        public IRepository _GetRepository() { return _IRepository ?? RepositoryMock.Object; }
	    public IRepository _SetRepository(IRepository obj){ _IRepository = obj; return obj;}

	    public CreateDepartmentHandler  Object
        {
            get
            {
                return new CreateDepartmentHandler(_GetRepository());
			}
        }

		public void VerifyAll()
		{
			RepositoryMock.VerifyAll();
		}
	}


    // Auto generated
	public partial class UpdateDepartmentHandlerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public UpdateDepartmentHandlerFactory()
            : this(MockBehavior.Default)
        {
        }

        public UpdateDepartmentHandlerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			RepositoryMock = new Mock<IRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// IRepository
		private IRepository _IRepository;
        public Mock<IRepository> RepositoryMock { get; set; }
        public IRepository _GetRepository() { return _IRepository ?? RepositoryMock.Object; }
	    public IRepository _SetRepository(IRepository obj){ _IRepository = obj; return obj;}

	    public UpdateDepartmentHandler  Object
        {
            get
            {
                return new UpdateDepartmentHandler(_GetRepository());
			}
        }

		public void VerifyAll()
		{
			RepositoryMock.VerifyAll();
		}
	}


    // Auto generated
	public partial class CreateInstructorWithCoursesHandlerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public CreateInstructorWithCoursesHandlerFactory()
            : this(MockBehavior.Default)
        {
        }

        public CreateInstructorWithCoursesHandlerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			RepositoryMock = new Mock<IRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// IRepository
		private IRepository _IRepository;
        public Mock<IRepository> RepositoryMock { get; set; }
        public IRepository _GetRepository() { return _IRepository ?? RepositoryMock.Object; }
	    public IRepository _SetRepository(IRepository obj){ _IRepository = obj; return obj;}

	    public CreateInstructorWithCoursesHandler  Object
        {
            get
            {
                return new CreateInstructorWithCoursesHandler(_GetRepository());
			}
        }

		public void VerifyAll()
		{
			RepositoryMock.VerifyAll();
		}
	}


    // Auto generated
	public partial class DeleteInstructorHandlerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public DeleteInstructorHandlerFactory()
            : this(MockBehavior.Default)
        {
        }

        public DeleteInstructorHandlerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			RepositoryMock = new Mock<IRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// IRepository
		private IRepository _IRepository;
        public Mock<IRepository> RepositoryMock { get; set; }
        public IRepository _GetRepository() { return _IRepository ?? RepositoryMock.Object; }
	    public IRepository _SetRepository(IRepository obj){ _IRepository = obj; return obj;}

	    public DeleteInstructorHandler  Object
        {
            get
            {
                return new DeleteInstructorHandler(_GetRepository());
			}
        }

		public void VerifyAll()
		{
			RepositoryMock.VerifyAll();
		}
	}


    // Auto generated
	public partial class ModifyInstructorAndCoursesHandlerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public ModifyInstructorAndCoursesHandlerFactory()
            : this(MockBehavior.Default)
        {
        }

        public ModifyInstructorAndCoursesHandlerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			RepositoryMock = new Mock<IRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// IRepository
		private IRepository _IRepository;
        public Mock<IRepository> RepositoryMock { get; set; }
        public IRepository _GetRepository() { return _IRepository ?? RepositoryMock.Object; }
	    public IRepository _SetRepository(IRepository obj){ _IRepository = obj; return obj;}

	    public ModifyInstructorAndCoursesHandler  Object
        {
            get
            {
                return new ModifyInstructorAndCoursesHandler(_GetRepository());
			}
        }

		public void VerifyAll()
		{
			RepositoryMock.VerifyAll();
		}
	}


    // Auto generated
	public partial class CreateStudentHandlerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public CreateStudentHandlerFactory()
            : this(MockBehavior.Default)
        {
        }

        public CreateStudentHandlerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			RepositoryMock = new Mock<IRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// IRepository
		private IRepository _IRepository;
        public Mock<IRepository> RepositoryMock { get; set; }
        public IRepository _GetRepository() { return _IRepository ?? RepositoryMock.Object; }
	    public IRepository _SetRepository(IRepository obj){ _IRepository = obj; return obj;}

	    public CreateStudentHandler  Object
        {
            get
            {
                return new CreateStudentHandler(_GetRepository());
			}
        }

		public void VerifyAll()
		{
			RepositoryMock.VerifyAll();
		}
	}


    // Auto generated
	public partial class DeleteStudentHandlerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public DeleteStudentHandlerFactory()
            : this(MockBehavior.Default)
        {
        }

        public DeleteStudentHandlerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			RepositoryMock = new Mock<IRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// IRepository
		private IRepository _IRepository;
        public Mock<IRepository> RepositoryMock { get; set; }
        public IRepository _GetRepository() { return _IRepository ?? RepositoryMock.Object; }
	    public IRepository _SetRepository(IRepository obj){ _IRepository = obj; return obj;}

	    public DeleteStudentHandler  Object
        {
            get
            {
                return new DeleteStudentHandler(_GetRepository());
			}
        }

		public void VerifyAll()
		{
			RepositoryMock.VerifyAll();
		}
	}


    // Auto generated
	public partial class ModifyStudentHandlerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public ModifyStudentHandlerFactory()
            : this(MockBehavior.Default)
        {
        }

        public ModifyStudentHandlerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			RepositoryMock = new Mock<IRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// IRepository
		private IRepository _IRepository;
        public Mock<IRepository> RepositoryMock { get; set; }
        public IRepository _GetRepository() { return _IRepository ?? RepositoryMock.Object; }
	    public IRepository _SetRepository(IRepository obj){ _IRepository = obj; return obj;}

	    public ModifyStudentHandler  Object
        {
            get
            {
                return new ModifyStudentHandler(_GetRepository());
			}
        }

		public void VerifyAll()
		{
			RepositoryMock.VerifyAll();
		}
	}


    // Auto generated
	public partial class DeleteCourseHandlerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public DeleteCourseHandlerFactory()
            : this(MockBehavior.Default)
        {
        }

        public DeleteCourseHandlerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			RepositoryMock = new Mock<IRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// IRepository
		private IRepository _IRepository;
        public Mock<IRepository> RepositoryMock { get; set; }
        public IRepository _GetRepository() { return _IRepository ?? RepositoryMock.Object; }
	    public IRepository _SetRepository(IRepository obj){ _IRepository = obj; return obj;}

	    public DeleteCourseHandler  Object
        {
            get
            {
                return new DeleteCourseHandler(_GetRepository());
			}
        }

		public void VerifyAll()
		{
			RepositoryMock.VerifyAll();
		}
	}


    // Auto generated
	public partial class UpdateCourseCreditsHandlerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public UpdateCourseCreditsHandlerFactory()
            : this(MockBehavior.Default)
        {
        }

        public UpdateCourseCreditsHandlerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			RepositoryMock = new Mock<IRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// IRepository
		private IRepository _IRepository;
        public Mock<IRepository> RepositoryMock { get; set; }
        public IRepository _GetRepository() { return _IRepository ?? RepositoryMock.Object; }
	    public IRepository _SetRepository(IRepository obj){ _IRepository = obj; return obj;}

	    public UpdateCourseCreditsHandler  Object
        {
            get
            {
                return new UpdateCourseCreditsHandler(_GetRepository());
			}
        }

		public void VerifyAll()
		{
			RepositoryMock.VerifyAll();
		}
	}


    // Auto generated
	public partial class StudentControllerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public StudentControllerFactory()
            : this(MockBehavior.Default)
        {
        }

        public StudentControllerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			StudentApplicationServiceMock = new Mock<IStudentApplicationService>(_MockBehaviour);
			QueryRepositoryMock = new Mock<IQueryRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// IStudentApplicationService
		private IStudentApplicationService _IStudentApplicationService;
        public Mock<IStudentApplicationService> StudentApplicationServiceMock { get; set; }
        public IStudentApplicationService _GetStudentApplicationService() { return _IStudentApplicationService ?? StudentApplicationServiceMock.Object; }
	    public IStudentApplicationService _SetStudentApplicationService(IStudentApplicationService obj){ _IStudentApplicationService = obj; return obj;}

		// IQueryRepository
		private IQueryRepository _IQueryRepository;
        public Mock<IQueryRepository> QueryRepositoryMock { get; set; }
        public IQueryRepository _GetQueryRepository() { return _IQueryRepository ?? QueryRepositoryMock.Object; }
	    public IQueryRepository _SetQueryRepository(IQueryRepository obj){ _IQueryRepository = obj; return obj;}

	    public StudentController  Object
        {
            get
            {
                return new StudentController(_GetStudentApplicationService(), _GetQueryRepository());
			}
        }

		public void VerifyAll()
		{
			StudentApplicationServiceMock.VerifyAll();
			QueryRepositoryMock.VerifyAll();
		}
	}


    // Auto generated
	public partial class InstructorControllerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public InstructorControllerFactory()
            : this(MockBehavior.Default)
        {
        }

        public InstructorControllerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			InstructorApplicationServiceMock = new Mock<IInstructorApplicationService>(_MockBehaviour);
			QueryRepositoryMock = new Mock<IQueryRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// IInstructorApplicationService
		private IInstructorApplicationService _IInstructorApplicationService;
        public Mock<IInstructorApplicationService> InstructorApplicationServiceMock { get; set; }
        public IInstructorApplicationService _GetInstructorApplicationService() { return _IInstructorApplicationService ?? InstructorApplicationServiceMock.Object; }
	    public IInstructorApplicationService _SetInstructorApplicationService(IInstructorApplicationService obj){ _IInstructorApplicationService = obj; return obj;}

		// IQueryRepository
		private IQueryRepository _IQueryRepository;
        public Mock<IQueryRepository> QueryRepositoryMock { get; set; }
        public IQueryRepository _GetQueryRepository() { return _IQueryRepository ?? QueryRepositoryMock.Object; }
	    public IQueryRepository _SetQueryRepository(IQueryRepository obj){ _IQueryRepository = obj; return obj;}

	    public InstructorController  Object
        {
            get
            {
                return new InstructorController(_GetInstructorApplicationService(), _GetQueryRepository());
			}
        }

		public void VerifyAll()
		{
			InstructorApplicationServiceMock.VerifyAll();
			QueryRepositoryMock.VerifyAll();
		}
	}


    // Auto generated
	public partial class DepartmentControllerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public DepartmentControllerFactory()
            : this(MockBehavior.Default)
        {
        }

        public DepartmentControllerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			DepartmentApplicationServiceMock = new Mock<IDepartmentApplicationService>(_MockBehaviour);
			QueryRepositoryMock = new Mock<IQueryRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// IDepartmentApplicationService
		private IDepartmentApplicationService _IDepartmentApplicationService;
        public Mock<IDepartmentApplicationService> DepartmentApplicationServiceMock { get; set; }
        public IDepartmentApplicationService _GetDepartmentApplicationService() { return _IDepartmentApplicationService ?? DepartmentApplicationServiceMock.Object; }
	    public IDepartmentApplicationService _SetDepartmentApplicationService(IDepartmentApplicationService obj){ _IDepartmentApplicationService = obj; return obj;}

		// IQueryRepository
		private IQueryRepository _IQueryRepository;
        public Mock<IQueryRepository> QueryRepositoryMock { get; set; }
        public IQueryRepository _GetQueryRepository() { return _IQueryRepository ?? QueryRepositoryMock.Object; }
	    public IQueryRepository _SetQueryRepository(IQueryRepository obj){ _IQueryRepository = obj; return obj;}

	    public DepartmentController  Object
        {
            get
            {
                return new DepartmentController(_GetDepartmentApplicationService(), _GetQueryRepository());
			}
        }

		public void VerifyAll()
		{
			DepartmentApplicationServiceMock.VerifyAll();
			QueryRepositoryMock.VerifyAll();
		}
	}


    // Auto generated
	public partial class CourseControllerFactory
	{
		private readonly MockBehavior _MockBehaviour;

	    public CourseControllerFactory()
            : this(MockBehavior.Default)
        {
        }

        public CourseControllerFactory(MockBehavior mockBehaviour)
        {
            _MockBehaviour = mockBehaviour;
			
			CourseApplicationServiceMock = new Mock<ICourseApplicationService>(_MockBehaviour);
			QueryRepositoryMock = new Mock<IQueryRepository>(_MockBehaviour);
		
			Initalise();
		}

		partial void Initalise();

		// ICourseApplicationService
		private ICourseApplicationService _ICourseApplicationService;
        public Mock<ICourseApplicationService> CourseApplicationServiceMock { get; set; }
        public ICourseApplicationService _GetCourseApplicationService() { return _ICourseApplicationService ?? CourseApplicationServiceMock.Object; }
	    public ICourseApplicationService _SetCourseApplicationService(ICourseApplicationService obj){ _ICourseApplicationService = obj; return obj;}

		// IQueryRepository
		private IQueryRepository _IQueryRepository;
        public Mock<IQueryRepository> QueryRepositoryMock { get; set; }
        public IQueryRepository _GetQueryRepository() { return _IQueryRepository ?? QueryRepositoryMock.Object; }
	    public IQueryRepository _SetQueryRepository(IQueryRepository obj){ _IQueryRepository = obj; return obj;}

	    public CourseController  Object
        {
            get
            {
                return new CourseController(_GetCourseApplicationService(), _GetQueryRepository());
			}
        }

		public void VerifyAll()
		{
			CourseApplicationServiceMock.VerifyAll();
			QueryRepositoryMock.VerifyAll();
		}
	}

}
