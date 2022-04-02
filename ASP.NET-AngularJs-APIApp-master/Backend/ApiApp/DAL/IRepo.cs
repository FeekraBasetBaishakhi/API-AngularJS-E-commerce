using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T, ID, STRING>
    {
        void AddUser(T u);
        void EditUser(T u);
        void DeleteUser(ID id);
        List<T> GetAllUsers();

        List<T> GetSearchUsers(STRING search);

        T GetUser(ID id);
    }

    public interface IRepo<T, ID, Search >
    {
        void AddProduct(ID id, T p);
        void EditPackage(ID id, T p);
        void DeletePackage(ID id);
        List<T> GetAllPackages(ID id);
        List<T> GetPackage(ID id);
        List<T> GetSearchPackage(Search search, ID id);

    }

    public interface IRepos<T, ID, Status>
    {
        List<T> GetOrder(ID id);
        List<T> GetSearchOrder(Status search, ID id);

        void EditStatus(ID id, Status status);
        List<T> GetAllOrders(ID id);

        List<T> GetAll();

        T GetOrders(ID id);
    }

    public interface IRepository<T, ST>
    {
        void Add(T e);
        List<T> Get();
        T Get(ST token);
        void Edit(T e);
        void Delete(ST token);
    }


    public interface IReposNotice<T, ID, Status>
    {
        List<T> GetAllNotice();
        List<T> GetSearchNotice(Status search);
        T GetNotice(ID id);
        void AddNotice(T n);
        void EditNotice(T n);
        void DeleteNotice(ID id);
    }
    public interface IReposRating<T, ID>
    {
        List<T> GetAllRatings();
        T GetRating(ID id);
        void AddRating(T r);
        void EditRating(T r);
        void DeleteRating(ID id);
        
    }

    public interface IReposVoucher<T, ID,SEARCH>
    {
        List<T> GetAllVouchers();
        List<T> GetSearchVouchers(SEARCH search);
        T GetVoucher(ID id);

        void AddVoucher(T v);
        void EditVoucher(T v);
        void DeleteVoucher(ID id);

    }
    public interface IReposAuditLog<T>
    {
        List<Auditlog> GetAllAuditLogs();
        void AddAuditLog(T a);
       

    }
    public interface IRepos<T, ID>
    {

        void EditUser(T us, ID id);

        Array[] Dashboard(ID id);


    }

}