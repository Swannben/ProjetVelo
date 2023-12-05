
package fr.polytech.soc.generated;

import jakarta.jws.WebMethod;
import jakarta.jws.WebParam;
import jakarta.jws.WebResult;
import jakarta.jws.WebService;
import jakarta.xml.bind.annotation.XmlSeeAlso;
import jakarta.xml.ws.RequestWrapper;
import jakarta.xml.ws.ResponseWrapper;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 4.0.0-M4
 * Generated source version: 3.0
 * 
 */
@WebService(name = "IService1", targetNamespace = "http://tempuri.org/")
@XmlSeeAlso({
    ObjectFactory.class
})
public interface IService1 {


    /**
     * 
     * @param arrivee
     * @param depart
     * @return
     *     returns java.lang.String
     */
    @WebMethod(operationName = "GetData", action = "http://tempuri.org/IService1/GetData")
    @WebResult(name = "GetDataResult", targetNamespace = "http://tempuri.org/")
    @RequestWrapper(localName = "GetData", targetNamespace = "http://tempuri.org/", className = "fr.polytech.soc.generated.GetData")
    @ResponseWrapper(localName = "GetDataResponse", targetNamespace = "http://tempuri.org/", className = "fr.polytech.soc.generated.GetDataResponse")
    public String getData(
        @WebParam(name = "depart", targetNamespace = "http://tempuri.org/")
        String depart,
        @WebParam(name = "arrivee", targetNamespace = "http://tempuri.org/")
        String arrivee);

}
