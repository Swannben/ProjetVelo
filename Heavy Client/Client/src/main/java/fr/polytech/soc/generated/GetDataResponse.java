
package fr.polytech.soc.generated;

import jakarta.xml.bind.JAXBElement;
import jakarta.xml.bind.annotation.XmlAccessType;
import jakarta.xml.bind.annotation.XmlAccessorType;
import jakarta.xml.bind.annotation.XmlElementRef;
import jakarta.xml.bind.annotation.XmlRootElement;
import jakarta.xml.bind.annotation.XmlType;


/**
 * <p>Classe Java pour anonymous complex type.
 * 
 * <p>Le fragment de schéma suivant indique le contenu attendu figurant dans cette classe.
 * 
 * <pre>
 * &lt;complexType&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="GetDataResult" type="{http://schemas.datacontract.org/2004/07/ProjetVelo}Feature" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "getDataResult"
})
@XmlRootElement(name = "GetDataResponse", namespace = "http://tempuri.org/")
public class GetDataResponse {

    @XmlElementRef(name = "GetDataResult", namespace = "http://tempuri.org/", type = JAXBElement.class, required = false)
    protected JAXBElement<Feature> getDataResult;

    /**
     * Obtient la valeur de la propriété getDataResult.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link Feature }{@code >}
     *     
     */
    public JAXBElement<Feature> getGetDataResult() {
        return getDataResult;
    }

    /**
     * Définit la valeur de la propriété getDataResult.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link Feature }{@code >}
     *     
     */
    public void setGetDataResult(JAXBElement<Feature> value) {
        this.getDataResult = value;
    }

}
