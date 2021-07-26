import { shallowMount } from '@vue/test-utils'
import sampleComponent from './sampleComponent.vue'

test('sampleComponent', () => {
  // render the component
  const wrapper = shallowMount(sampleComponent)

  // should not allow for `username` less than 7 characters, excludes whitespace
  wrapper.setProps({ data: 'data',title: 'title' });

  wrapper.setData({ datas: ['a', 'b', 'c', 'd'] });
})