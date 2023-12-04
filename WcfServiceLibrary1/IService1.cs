using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ProjetVelo
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Task<string> GetData(string depart, string arrivee);

        

        // TODO: ajoutez vos opérations de service ici
    }

}
