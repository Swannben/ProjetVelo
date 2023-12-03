
package fr.polytech.soc.generated;

import jakarta.xml.bind.annotation.XmlAccessType;
import jakarta.xml.bind.annotation.XmlAccessorType;
import jakarta.xml.bind.annotation.XmlType;


/**
 * <p>Classe Java pour Summary complex type.
 * 
 * <p>Le fragment de schéma suivant indique le contenu attendu figurant dans cette classe.
 * 
 * <pre>
 * &lt;complexType name="Summary"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="distance" type="{http://www.w3.org/2001/XMLSchema}float" minOccurs="0"/&gt;
 *         &lt;element name="duration" type="{http://www.w3.org/2001/XMLSchema}float" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "Summary", propOrder = {
    "distance",
    "duration"
})
public class Summary {

    protected Float distance;
    protected Float duration;

    /**
     * Obtient la valeur de la propriété distance.
     * 
     * @return
     *     possible object is
     *     {@link Float }
     *     
     */
    public Float getDistance() {
        return distance;
    }

    /**
     * Définit la valeur de la propriété distance.
     * 
     * @param value
     *     allowed object is
     *     {@link Float }
     *     
     */
    public void setDistance(Float value) {
        this.distance = value;
    }

    /**
     * Obtient la valeur de la propriété duration.
     * 
     * @return
     *     possible object is
     *     {@link Float }
     *     
     */
    public Float getDuration() {
        return duration;
    }

    /**
     * Définit la valeur de la propriété duration.
     * 
     * @param value
     *     allowed object is
     *     {@link Float }
     *     
     */
    public void setDuration(Float value) {
        this.duration = value;
    }

}
