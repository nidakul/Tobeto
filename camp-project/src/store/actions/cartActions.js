//Sepet ile ilgili aksiyonlar 

export const ADD_TO_CART = "ADD_TO_CART"
export const REMOVE_FROM_CART = "REMOVE_FROM_CART"

export function addToCart(category){
return {
    type : ADD_TO_CART , //aksiyon ismi.
    payload : category //ne eklemek istiyorsun sepete. State'i etkileyecek olan veri
}
}

export function removeFromCart(category){
    return {
        type : REMOVE_FROM_CART , 
        payload : category 
    }
}
