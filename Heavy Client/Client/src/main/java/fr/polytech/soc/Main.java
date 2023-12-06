package fr.polytech.soc;

import fr.polytech.soc.generated.IService1;
import fr.polytech.soc.generated.Service1;
import org.json.JSONArray;
import org.json.JSONObject;

import javax.xml.namespace.QName;
import java.net.URL;
import java.util.ArrayList;
import java.util.Scanner;

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
            String jsonItinerary = port.getData(depart, arrivee);

            JSONObject jsonObject = new JSONObject(jsonItinerary);

            JSONArray steps = jsonObject.getJSONArray("steps");
            ArrayList<String> stepsList = new ArrayList<String>();

            for (int i = 0; i < steps.length(); i++) {
                String stepStr ="";
                JSONObject step = steps.getJSONObject(i);
                double distance = step.getDouble("distance");
                double duration = step.getDouble("duration");
                String instruction = step.getString("instruction");

                stepStr+=("Step " + (i + 1) + ":\n");
                stepStr+=("  Distance: " + distance + " meters\n");
                stepStr+=("  Duration: " + duration + " seconds\n");
                stepStr+=("  Instruction: " + instruction+"\n");
                stepStr+="\n";
                stepsList.add(stepStr);
            }
            int i=0;
            boolean quit=false;
            while(quit!=true){
                System.out.println(stepsList.get(i));
                System.out.println("Press n to continue, p to go back, or q to quit");
                String input = scanner.nextLine();
                if(input.equals("q")){
                    quit=true;
                }
                else if(input.equals("n")){
                    if(i<stepsList.size()-1){
                        i++;
                    }
                    else{
                        System.out.println("You are at the end of the itinerary");
                    }
                }
                else if(input.equals("p")){
                    if(i>0){
                        i--;
                    }
                    else{
                        System.out.println("You are at the beginning of the itinerary");
                    }
                }
                else{
                    System.out.println("Invalid input");
                }

            }



        } catch (Exception e) {
            e.printStackTrace();
        }
    }


}