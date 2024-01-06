import { ADD_TO_CART, REMOVE_FROM_CART } from "../actions/cartActions";
import { cartItems } from "../initialValues/cartItems";

const initialState = {
  cartItems: cartItems,
};

export default function cartReducer(state = initialState, { type, payload }) {
  //state = default başlangıç değeri
  switch (
    type //hangi type gelirse napsın
  ) {
    case ADD_TO_CART:
      let category = state.cartItems.find((c) => c.category.id === payload.id);
      if (category) {
        category.quantity++;
        return {
          ...state,
        };
      } else {
        return {
          ...state,
          cartItems: [...state.cartItems, { quantity: 1, category: payload }],
        };
      }
    case REMOVE_FROM_CART:
      return {
        ...state,
        cartItems: state.cartItems.filter((c) => c.category.id !== payload.id),
      };
    default:
      return state;
  }
}
