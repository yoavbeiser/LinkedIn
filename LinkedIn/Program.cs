using System;
using LinkedIn.ProfileManage;
using LinkedIn.ProfileManage.PostManage;
using LinkedIn.ProfileManage.EducationManage;
namespace LinkedIn
{
	public class Program
	{
		public static void Main(string[] argv)
		{

            LinkedIn linkedIn = new LinkedIn();

            #region Users
            User userRoy = new User("Roy", "1", "1", 11, Profession.Manager, new CreditCard(4580, DateTime.Now, 434));
            User userAmit = new User("amit", "2", "2", 12, Profession.Manager, new CreditCard(4580, DateTime.Now, 432));
            User userDan = new User("Dan", "3", "3", 13, Profession.Manager, new CreditCard(4580, DateTime.Now, 431));
            User userDorit = new User("Dorit", "4", "4", 14, Profession.Manager, new CreditCard(4580, DateTime.Now, 430));
            #endregion
            
            #region Profiles
            Profile RoyProfile = new Profile(userRoy,"Roy....");
            Profile AmitProfile = new Profile(userAmit, "Amit....");
            Profile DanProfile = new Profile(userDan, "Dan....");
            Profile DoritProfile = new Profile(userDorit, "Dorit....");
            #endregion

            #region Add Work Places
            RoyProfile.AddWorkPlace(new WorkPlace(new Company("Teva Pharmaceutical Industries"), DateTime.Today.AddDays(-60), DateTime.Today.AddDays(-40)));
            RoyProfile.AddWorkPlace(new WorkPlace(new Company("The Israel Electric Corporation"), DateTime.Today.AddDays(-160), DateTime.Today.AddDays(-140)));
            RoyProfile.AddWorkPlace(new WorkPlace(new Company("Intel"), DateTime.Today.AddDays(-260), DateTime.Today.AddDays(-240)));
            RoyProfile.AddWorkPlace(new WorkPlace(new Company("Amdocs"), DateTime.Today.AddDays(-360), DateTime.Today.AddDays(-340)));

            AmitProfile.AddWorkPlace(new WorkPlace(new Company("ADAMA Agricultural Solutions"), DateTime.Today.AddDays(-70), DateTime.Today.AddDays(-40)));
            AmitProfile.AddWorkPlace(new WorkPlace(new Company("Paz"), DateTime.Today.AddDays(-170), DateTime.Today.AddDays(-140)));
            AmitProfile.AddWorkPlace(new WorkPlace(new Company("Rafael"), DateTime.Today.AddDays(-270), DateTime.Today.AddDays(-240)));
            AmitProfile.AddWorkPlace(new WorkPlace(new Company("Bezeq"), DateTime.Today.AddDays(-370), DateTime.Today.AddDays(-340)));

            DanProfile.AddWorkPlace(new WorkPlace(new Company("Mifal Hapais"), DateTime.Today.AddDays(-70), DateTime.Today.AddDays(-40)));
            DanProfile.AddWorkPlace(new WorkPlace(new Company("Iscar"), DateTime.Today.AddDays(-170), DateTime.Today.AddDays(-140)));
            DanProfile.AddWorkPlace(new WorkPlace(new Company("Vishay Israel"), DateTime.Today.AddDays(-270), DateTime.Today.AddDays(-240)));
            DanProfile.AddWorkPlace(new WorkPlace(new Company("Delek Israel"), DateTime.Today.AddDays(-370), DateTime.Today.AddDays(-340)));

            DoritProfile.AddWorkPlace(new WorkPlace(new Company("Check Point Software"), DateTime.Today.AddDays(-70), DateTime.Today.AddDays(-40)));
            DoritProfile.AddWorkPlace(new WorkPlace(new Company("Playtika"), DateTime.Today.AddDays(-170), DateTime.Today.AddDays(-140)));
            DoritProfile.AddWorkPlace(new WorkPlace(new Company("Coca Cola (Israel)"), DateTime.Today.AddDays(-270), DateTime.Today.AddDays(-240)));
            DoritProfile.AddWorkPlace(new WorkPlace(new Company("Delta Galil"), DateTime.Today.AddDays(-370), DateTime.Today.AddDays(-340)));
            #endregion

            #region Add Education
            RoyProfile.AddEducation(new Education(new Institution("Harvard University"), DateTime.Today.AddYears(-13), DateTime.Today.AddYears(-9)));
            RoyProfile.AddEducation(new Education(new Institution("Stanford University"), DateTime.Today.AddYears(-8), DateTime.Today.AddYears(-4)));
            RoyProfile.AddEducation(new Education(new Institution("Columbia University"), DateTime.Today.AddYears(-3), DateTime.Today.AddYears(-1)));
            RoyProfile.AddEducation(new Education(new Institution("University of Oxford"), DateTime.Today.AddYears(-1), DateTime.Today.AddDays(-10)));

            AmitProfile.AddEducation(new Education(new Institution("California Institute of Technology (Caltech)"), DateTime.Today.AddYears(-23), DateTime.Today.AddYears(-20)));
            AmitProfile.AddEducation(new Education(new Institution("Karolinska Institute"), DateTime.Today.AddYears(-19), DateTime.Today.AddYears(-17)));
            AmitProfile.AddEducation(new Education(new Institution("Harvard University"), DateTime.Today.AddYears(-15), DateTime.Today.AddYears(-12)));
            AmitProfile.AddEducation(new Education(new Institution("Massachusetts Institute of Technology (MIT)"), DateTime.Today.AddYears(-9), DateTime.Today.AddYears(-3)));

            DanProfile.AddEducation(new Education(new Institution("Massachusetts Institute of Technology (MIT)"), DateTime.Today.AddYears(-12), DateTime.Today.AddYears(-9)));
            DanProfile.AddEducation(new Education(new Institution("Imperial College London"), DateTime.Today.AddYears(-9), DateTime.Today.AddYears(-6)));
            DanProfile.AddEducation(new Education(new Institution("ETH Zurich (Swiss Federal Institute of Technology)"), DateTime.Today.AddYears(-6), DateTime.Today.AddYears(-4)));
            DanProfile.AddEducation(new Education(new Institution("Columbia University"), DateTime.Today.AddYears(-4), DateTime.Today.AddYears(-1)));

            DoritProfile.AddEducation(new Education(new Institution("University of Pennsylvania"), DateTime.Today.AddYears(-30), DateTime.Today.AddYears(-25)));
            DoritProfile.AddEducation(new Education(new Institution("Massachusetts Institute of Technology (MIT)"), DateTime.Today.AddYears(-20), DateTime.Today.AddYears(-15)));
            DoritProfile.AddEducation(new Education(new Institution("Columbia University"), DateTime.Today.AddYears(-15), DateTime.Today.AddYears(-10)));
            DoritProfile.AddEducation(new Education(new Institution("Imperial College London"), DateTime.Today.AddYears(-10), DateTime.Today.AddYears(-3)));
            #endregion

            #region Add Connections
            RoyProfile.AddConnection(userDan);
            RoyProfile.AddConnection(userAmit);
            RoyProfile.RemoveConnection(userDan);

            AmitProfile.AddConnection(userDorit);
            AmitProfile.AddConnection(userDan);

            DanProfile.AddConnection(userRoy);
            DanProfile.AddConnection(userAmit);

            DoritProfile.AddConnection(userRoy);
            DoritProfile.AddConnection(userAmit);
            #endregion

            #region Add Profiles
            linkedIn.AddProfile(RoyProfile);
            linkedIn.AddProfile(AmitProfile);
            linkedIn.AddProfile(DanProfile);
            linkedIn.AddProfile(DoritProfile);
            #endregion

            #region Posts
            Post post1 = new Post("new worker!!!", new Picture("http:linkWorker"), userDan);
            linkedIn.AddPost(post1);
            Post post2 = new Post("Learned new University course!!!", new Picture("http:UniCourse"), userRoy);
            linkedIn.AddPost(post2);
            #endregion

            #region Like and comment posts
            post1.AddLike(new Like(userRoy));
            post1.AddLike(new Like(userDorit));
            post1.AddComment(new Comment(userAmit,"wow nice!!!"));
            post1.AddComment(new Comment(userRoy, "Good luck!!!"));
            post2.AddLike(new Like(userAmit));
            post2.AddLike(new Like(userDorit));
            post2.AddComment(new Comment(userDorit, "Good luck!!!"));
            post2.AddComment(new Comment(userDan, "very nice!!!"));
            #endregion

            Console.WriteLine(linkedIn);
        }
	}
}

