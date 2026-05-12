import { Box } from "@mui/material"
import ProductCards from "./ProductCards"
import type { Product } from "../../app/models/product"

type Props = {
    products: Product[]
} 


export default function ProductList({products}: Props) {
  return (
        <Box sx={{display:'flex', flexWrap:'wrap', gap:3, justifyContent:'center'}}>
        {products.map(product => ( // item iterates over the array taking on board all parameters in an array 
         <ProductCards key={product.id} product={product}/>
        ))}
      </Box>
  )
}