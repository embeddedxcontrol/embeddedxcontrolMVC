#region Using Namespaces...

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.Entity.Validation;
using embeddedxcontrol.Repo.GenericRepository;
using System.Reflection;
using System.IO;

#endregion

namespace embeddedxcontrol.Repo.UnitOfWork
{
    /// <summary>
    /// Unit of Work class responsible for DB transactions
    /// </summary>
    public class UnitOfWork : IDisposable
    {
        #region Private member variables...

        private excEntities _context = null;
        private GenericRepository<AspNetBio> _bioRepository;
        private GenericRepository<AspNetFeedback> _feedbackRepository;
        private GenericRepository<AspNetImage> _imageRepository;
        private GenericRepository<AspNetProject> _projectRepository;
        private GenericRepository<AspNetProjectUpdate> _projectUpdateRepository;
        private GenericRepository<AspNetTopicsList> _topicsRepository;
        private GenericRepository<AspNetUser> _userRepository;
        private GenericRepository<AspNetVersionControl> _versionControlRepository;
        #endregion

        public UnitOfWork()
        {
            _context = new excEntities();
        }

        #region Public Repository Creation properties...

        /// <summary>
        /// Get/Set Property for bio repository.
        /// </summary>
        public GenericRepository<AspNetBio> BioRepository
        {
            get
            {
                if (this._bioRepository == null)
                    this._bioRepository = new GenericRepository<AspNetBio>(_context);
                return _bioRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for feedback repository.
        /// </summary>
        public GenericRepository<AspNetFeedback> FeedbackRepository
        {
            get
            {
                if (this._feedbackRepository == null)
                    this._feedbackRepository = new GenericRepository<AspNetFeedback>(_context);
                return _feedbackRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for image repository.
        /// </summary>
        public GenericRepository<AspNetImage> ImageRepository
        {
            get
            {
                if (this._imageRepository == null)
                    this._imageRepository = new GenericRepository<AspNetImage>(_context);
                return _imageRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for project repository.
        /// </summary>
        public GenericRepository<AspNetProject> ProjectRepository
        {
            get
            {
                if (this._projectRepository == null)
                    this._projectRepository = new GenericRepository<AspNetProject>(_context);
                return _projectRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for project update repository.
        /// </summary>
        public GenericRepository<AspNetProjectUpdate> ProjectUpdateRepository
        {
            get
            {
                if (this._projectUpdateRepository == null)
                    this._projectUpdateRepository = new GenericRepository<AspNetProjectUpdate>(_context);
                return _projectUpdateRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for topics repository.
        /// </summary>
        public GenericRepository<AspNetTopicsList> TopicsRepository
        {
            get
            {
                if (this._topicsRepository == null)
                    this._topicsRepository = new GenericRepository<AspNetTopicsList>(_context);
                return _topicsRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for user data repository.
        /// </summary>
        public GenericRepository<AspNetUser> UserRepository
        {
            get
            {
                if (this._userRepository == null)
                    this._userRepository = new GenericRepository<AspNetUser>(_context);
                return _userRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for version control repository.
        /// </summary>
        public GenericRepository<AspNetVersionControl> VersionControlRepository
        {
            get
            {
                if (this._versionControlRepository == null)
                    this._versionControlRepository = new GenericRepository<AspNetVersionControl>(_context);
                return _versionControlRepository;
            }
        }


        #endregion

        #region Public member methods...
        /// <summary>
        /// Save method.
        /// </summary>
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                var outputLines = new List<string>();
                foreach (var eve in e.EntityValidationErrors)
                {
                    outputLines.Add(string.Format(
                        "{0}: Entity of type \"{1}\" in state \"{2}\" has the following validation errors:", DateTime.Now,
                        eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }


                string _codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder _uri = new UriBuilder(_codeBase);
                string _path = Uri.UnescapeDataString(_uri.Path);
                string _filePath = Path.GetDirectoryName(_path);
                string _fullFilePath = _filePath + @"\errors.txt";
                System.IO.File.AppendAllLines(_fullFilePath, outputLines);

                throw e;
            }

        }

        #endregion

        #region Implementing IDiosposable...

        #region private dispose variable declaration...
        private bool disposed = false;
        #endregion

        /// <summary>
        /// Protected Virtual Dispose method
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Debug.WriteLine("UnitOfWork is being disposed");
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
