package fr.polytech.soc;
import java.util.Scanner;

import fr.polytech.soc.generated.Feature;
import fr.polytech.soc.generated.IService1;
import fr.polytech.soc.generated.Service1;

import javax.xml.namespace.QName;
import java.net.URL;

public class Main {

    public static void main(String[] args) {
        try {            // Créez une URL vers le WSDL de votre service en C#

            URL wsdlURL = new URL("http://localhost:8080/Design_Time_Addresses/ProjetVelo/Service1/?wsdl");
            // Spécifiez le nom du service et de la portée
            QName serviceName = new QName("http://tempuri.org/", "Service1");
            QName portName = new QName("http://tempuri.org/", "BasicHttpBinding_IService1");

            // Créez le service et le port à partir de l'URL et du QName

            // Créez le service en utilisant les informations ci-dessus
            Service1 service = new Service1(wsdlURL, serviceName);

            // Obtenez le port du service pour le service en C#
            IService1 port = service.getBasicHttpBindingIService1();

            // Demander a l'utilisateur de saisir les points de départ et d'arrivée
            Scanner scanner = new Scanner(System.in);
            System.out.println("Entrez le point de départ: ");
            String depart = scanner.nextLine();
            System.out.println("Entrez le point d'arrivée: ");
            String arrivee = scanner.nextLine();
            System.out.println("Calcul de l'itinéraire entre " + depart + " et " + arrivee);
            String itinerary = port.getData(depart, arrivee);

            // Affichez le résultat
            System.out.println("Itinéraire: " + itinerary);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }


}