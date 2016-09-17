using System.Collections.Generic;
using System.Threading.Tasks;

/* AUTHOR       : BILAL ASIF MIRZA
   DATE STARTED : 21 AUGUST 2016
   DATE ENDED   : 23 AUGUST 2016
    =====================================================================================================
        PLEASE READ THE FOLLOWING DETAILS REGARDING THIS INTERFACE AS IT WILL HELP YOU TO UNDERSTAND :) 
    =====================================================================================================
/*
 *  ==> This interface will provide all the "basic core" functionalities to the derived and implimented
        Repository class
    
    ==> IRepo<T> will consist of CRUD operations 

    ==> IRepo<T> will consist only those members THAT YOU HAVE TO USE RIGHT NOW 

    ==> Meaning is that do not lazy write all the members instantly(quickly) like find , get,add,etc

    ==> Finally IRepo<T> will be inherited by a class Named Repository that will impliment all these
        members.
         
    ==> Then CustomerRepository , CarRepository will inherit Repository and impliment further methods
        (specialization) 

    ==> Only Add Those Members or Types that you want to use at this very moment !
*/


namespace AutoLotEntityDLL.Repository
{
  internal interface IRepo<T>
    {
        int Add(T entity);
        int AddRange(List<T> entites);
        Task<int> AddAsync(T entity);
        Task<int> AddRangeAsync(List<T> entity);

        int Delete(T entity);
        Task<int> DeleteAsync(T entity);

        int Save();
        Task<int> SaveAsync();

        int Update(T entity);
        Task<int> UpdateAsync(T entity);

        List<T> GetAll();
        T Get(int? id);
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();

    }
}
